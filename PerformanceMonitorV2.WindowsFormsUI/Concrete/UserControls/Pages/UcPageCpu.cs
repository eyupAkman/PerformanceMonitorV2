using System;
using System.Drawing;
using System.Windows.Forms;
using PerformanceMonitorV2.Entities.Concrete.FixedData;
using PerformanceMonitorV2.Entities.Concrete.LiveData;
using PerformanceMonitorV2.WindowsFormsUI.Abstract;
using PerformanceMonitorV2.WindowsFormsUI.Concrete.PlayerF;

namespace PerformanceMonitorV2.WindowsFormsUI.Concrete.UserControls.Pages
{
    public partial class UcPageCpu : UserControl, IChart, IHud, IInfo, IPlayer
    {
        #region Fields

        // Data source instance
        private readonly CpuData _data = new CpuData();

        #endregion

        #region Constructor

        public UcPageCpu()
        {
            InitializeComponent();
            ChartSet();
            SetLabels();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Specification preset
        /// </summary>
        private void SetLabels()
        {
            var details = new CpuSpecs().GetDetails();
            if (details == null) return;
            lblManBox.Text = details.Manufacturer;
            lblFamBox.Text = details.Family;
            lblModBox.Text = details.Model;
            lblCorBox.Text = $@"{details.Cores} / {details.Threads}";
            lblCloBox.Text = $@"{details.Clock} / {details.Boost}";
        }

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
            Player.SetPlayer(Hud, Chart, _data.GetCounterList(), _data.GetSeriesList(), "cpu");
        }

        /// <summary>
        /// Detailed specifications page get and view
        /// </summary>
        /// <param name="sender"> Event object </param>
        /// <param name="e"> Event object </param>
        private void MoreDetails(object sender, EventArgs e)
        {
            var page = new UcPageCpuDetail();
            page.Location = new Point((Width - page.Width) / 2, (Height - page.Height) / 2);
            Controls.Add(page);
            page.BringToFront();
        }

        #endregion
    }
}
