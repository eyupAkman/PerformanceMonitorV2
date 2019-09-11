using System.Collections.Generic;
using System.Diagnostics;
using PerformanceMonitorV2.Entities.Abstract;

namespace PerformanceMonitorV2.Entities.Concrete.LiveData
{
    public class CompactData : ILiveData
    {
        #region Fields

        // Compact data counter list
        private static readonly List<PerformanceCounter> CounterList = new List<PerformanceCounter>();

        // Compact series name list
        private static readonly List<string> SeriesNameList = new List<string>();

        // Network counter list
        private static readonly List<PerformanceCounter> Network = new List<PerformanceCounter>();

        // Compact temporary value
        private static float _result;

        #endregion

        #region Methods

        #region Return type ones

        public float GetValue(int index)
        {
            switch (index)
            {
                case 0:
                case 1:
                case 2:
                    _result = CounterList[index].NextValue();
                    if (_result > 100) _result = 100;
                    break;
                case 3:
                {
                    _result = 0;
                    foreach (var counter in Network)
                    {
                        _result += counter.NextValue();
                    }

                    break;
                }
            }

            return _result;
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
            CounterList.Add(new PerformanceCounter("Processor", "% Processor Time", "_Total"));
            SeriesNameList.Add("Cpu Total");
            CounterList.Add(new PerformanceCounter("Memory", "% Committed Bytes In Use"));
            SeriesNameList.Add("Ram Total");
            CounterList.Add(new PerformanceCounter("PhysicalDisk", "% Disk Time", "_Total"));
            SeriesNameList.Add("Disk Total");
            foreach (var instance in new PerformanceCounterCategory("Network Interface").GetInstanceNames())
            {
                Network.Add(new PerformanceCounter("Network Interface", "Bytes Total/sec", instance));
                SeriesNameList.Add($@"{instance} Total");
            }
        }

        #endregion

        #endregion
    }
}