using System.Collections.Generic;
using System.Diagnostics;
using PerformanceMonitorV2.Entities.Abstract;

namespace PerformanceMonitorV2.Entities.Concrete.LiveData
{
    public class RamData : ILiveData
    {
        #region Fields 

        // Ram counter list
        private static readonly List<PerformanceCounter> CounterList = new List<PerformanceCounter>();

        // Ram series name list
        private static readonly List<string> SeriesNameList = new List<string>();

        // Ram temporary value
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
            CounterList.Add(new PerformanceCounter("Memory", "% Committed Bytes In Use"));
            SeriesNameList.Add("Total");
        }

        #endregion

        #endregion
    }
}
