using System.Windows.Forms;
using PerformanceMonitorV2.Entities.Concrete.LiveData;
using PerformanceMonitorV2.WindowsFormsUI.Abstract;
using PerformanceMonitorV2.WindowsFormsUI.Concrete.PlayerF;

namespace PerformanceMonitorV2.WindowsFormsUI.Concrete.UserControls.Pages
{
    public partial class UcPageNet : UserControl, IChart, IHud, IInfo, IPlayer
    {
        #region Fields

        // Data source instance
        private readonly NetData _data = new NetData();

        #endregion

        #region Constructor

        public UcPageNet()
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
            Player.SetPlayer(Hud, Chart, _data.GetCounterList(), _data.GetSeriesList(), "net");
        }

        #endregion
    }
}
