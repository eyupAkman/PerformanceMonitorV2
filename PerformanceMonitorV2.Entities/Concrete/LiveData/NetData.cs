using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using PerformanceMonitorV2.Entities.Abstract;

namespace PerformanceMonitorV2.Entities.Concrete.LiveData
{
    public class NetData : ILiveData
    {
        #region Fields

        // Network counter list
        public static readonly List<PerformanceCounter> CounterList = new List<PerformanceCounter>();

        // Network series name list
        public static readonly List<string> SeriesNameList = new List<string>();

        // Network temporary value
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
            var counterName = new[] {"Bytes Total/sec", "Bytes Received/sec", "Bytes Sent/sec"};
            var instances = new PerformanceCounterCategory("Network Interface").GetInstanceNames().ToList();
            instances.Sort();
            foreach (var instance in instances)
            {
                for (int i = 0; i < 3; i++)
                {
                    CounterList.Add(new PerformanceCounter("Network Interface", counterName[i], instance));
                    SeriesNameList.Add(SetSeriesName(instance, i));
                }
            }
        }

        private string SetSeriesName(string instance, int i)
        {
            string temp = "";
            switch (i)
            {
                case 0:
                    temp = @"Total";
                    break;
                case 1:
                    temp = @"Download";
                    break;
                case 2:
                    temp = @"Upload";
                    break;
            }

            return $@"{instance} {temp}";
        }

        #endregion

        #endregion
    }
}