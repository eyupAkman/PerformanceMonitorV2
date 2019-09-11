using System.Threading.Tasks;
using PerformanceMonitorV2.Entities.Concrete.FixedData;
using PerformanceMonitorV2.Entities.Concrete.LiveData;
using PerformanceMonitorV2.Management.Abstract;

namespace PerformanceMonitorV2.Management.Concrete
{
    public class DataManager : IDataManager
    {
        public void SetSources()
        {
            #region Live data setups

            new CompactData().SetInstances();
            Task.Factory.StartNew(new CpuData().SetInstances);
            Task.Factory.StartNew(new RamData().SetInstances);
            Task.Factory.StartNew(new DiskData().SetInstances);
            Task.Factory.StartNew(new NetData().SetInstances);

            #endregion

            #region Fixed data Setups

            Task.Factory.StartNew(new CpuSpecs().SetSpecs);

            #endregion
        }
    }
}