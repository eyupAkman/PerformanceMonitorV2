using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using PerformanceMonitorV2.Entities.Abstract;

namespace PerformanceMonitorV2.Entities.Concrete.LiveData
{
    public class CpuData : ILiveData
    {
        #region Fields

        // Cpu counter list
        private static readonly List<PerformanceCounter> CounterList = new List<PerformanceCounter>();

        // Cpu series name list
        private static readonly List<string> SeriesNameList = new List<string>();

        // Cpu temporary value
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
            return SeriesNameList.Count;
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
            var instances = new PerformanceCounterCategory("Processor").GetInstanceNames().ToList();
            instances.Sort();
            foreach (var instance in instances)
            {
                CounterList.Add(new PerformanceCounter("Processor", "% Processor Time", instance));
                SeriesNameList.Add(SetSeriesName(instance));
            }
        }

        private string SetSeriesName(string instance)
        {
            return instance.Equals("_Total") ? @"Total" : $@"Thread {instance}";
        }

        #endregion

        #endregion
    }
}