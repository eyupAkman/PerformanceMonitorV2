using System.Windows.Forms;
using PerformanceMonitorV2.Entities.Concrete.LiveData;
using PerformanceMonitorV2.WindowsFormsUI.Abstract;
using PerformanceMonitorV2.WindowsFormsUI.Concrete.PlayerF;

namespace PerformanceMonitorV2.WindowsFormsUI.Concrete.UserControls.Pages
{
    public partial class UcPageRam : UserControl, IChart, IHud, IInfo, IPlayer
    {
        #region Fields

        // Data source instance
        private readonly RamData _data = new RamData();

        #endregion

        #region Constructor

        public UcPageRam()
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
            Player.SetPlayer(Hud, Chart, _data.GetCounterList(), _data.GetSeriesList(), "ram");
        }

        #endregion
    }
}
