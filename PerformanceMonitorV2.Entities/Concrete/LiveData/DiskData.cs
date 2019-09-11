using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using PerformanceMonitorV2.Entities.Abstract;

namespace PerformanceMonitorV2.Entities.Concrete.LiveData
{
    public class DiskData : ILiveData
    {
        #region Fields

        // Disk counter list
        private static readonly List<PerformanceCounter> CounterList = new List<PerformanceCounter>();

        // Disk series name list
        private static readonly List<string> SeriesNameList = new List<string>();

        // Disk temporary value
        private static float _result;

        #endregion

        #region Methods

        #region Return type ones

        public float GetValue(int index)
        {
            _result = CounterList[index].NextValue();
            return _result > 100 ? 100 : _result;
        }

        public int GetCount()
        {
            return CounterList.Count;
        }

        public string GetName(int index)
        {
            return SeriesNameList[index];
        }

        public List<PerformanceCounter> GetCounterList()
        {
            return CounterList;
        }

        public List<string> GetSeriesList()
        {
            return SeriesNameList;
        }

        #endregion

        #region Setups

        public void SetInstances()
        {
            var counterName = new[] {"% Disk Time", "% Disk Read Time", "% Disk Write Time"};
            var instances = new PerformanceCounterCategory("PhysicalDisk").GetInstanceNames()
                .Where(name => !name.Equals("_Total")).ToList();
            instances.Sort();
            foreach (var instance in instances)
            {
                for (int i = 0; i < 3; i++)
                {
                    CounterList.Add(new PerformanceCounter("PhysicalDisk", counterName[i], instance));
                    SeriesNameList.Add(SetSeriesName(instance, i));
                }
            }
        }

        private string SetSeriesName(string instance, int i)
        {
            var temp = "";
            switch (i)
            {
                case 0:
                    temp = @"Total";
                    break;
                case 1:
                    temp = @"Read";
                    break;
                case 2:
                    temp = @"Write";
                    break;
            }

            return $@"({instance[2]}:) {temp}";
        }

        #endregion

        #endregion
    }
}