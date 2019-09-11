using System.Collections.Generic;
using System.Diagnostics;

namespace PerformanceMonitorV2.Entities.Abstract
{
    public interface ILiveData
    {
        /// <summary>
        /// Returns a value from the corresponding counter in the list
        /// </summary>
        /// <param name="index"> Performance counter index </param>
        /// <returns> Measured value </returns>
        float GetValue(int index);

        /// <summary>
        /// Return the performance counter lists count
        /// </summary>
        /// <returns> List count </returns>
        int GetCount();

        /// <summary>
        /// Returns the name from the corresponding in the list
        /// </summary>
        /// <param name="index"> Name index </param>
        /// <returns> Corresponding name </returns>
        string GetName(int index);

        /// <summary>
        /// Return the performance counter list
        /// </summary>
        /// <returns> Performance counter list </returns>
        List<PerformanceCounter> GetCounterList();

        /// <summary>
        /// Returns the name list
        /// </summary>
        /// <returns> Name list </returns>
        List<string> GetSeriesList();

        /// <summary>
        /// Setup for custom hardware component
        /// </summary>
        void SetInstances();
    }
}