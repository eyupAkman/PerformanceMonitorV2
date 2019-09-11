using System.Windows.Forms;
using PerformanceMonitorV2.Entities.Concrete.LiveData;
using PerformanceMonitorV2.WindowsFormsUI.Abstract;
using PerformanceMonitorV2.WindowsFormsUI.Concrete.PlayerF;

namespace PerformanceMonitorV2.WindowsFormsUI.Concrete.UserControls.Pages
{
    public partial class UcPageDisk : UserControl, IChart, IHud, IInfo, IPlayer
    {
        #region Fields

        // Data source instance
        private readonly DiskData _data = new DiskData();

        #endregion

        #region Constructor

        public UcPageDisk()
        {
            InitializeComponent();
            ChartSet();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Add series into chart with names
        /// </summary>
        public void ChartSet()
        {
            Chart.AddSeries(_data.GetSeriesList());
        }

        /// <summary>
        /// Player setup sources
        /// </summary>
        public void SetPlayer()
        {
            Player.SetPlayer(Hud, Chart, _data.GetCounterList(), _data.GetSeriesList(), "disk");
        }

        #endregion
    }
}