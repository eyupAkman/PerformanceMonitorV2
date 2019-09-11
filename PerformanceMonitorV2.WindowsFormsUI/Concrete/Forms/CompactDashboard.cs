using System;
using System.Windows.Forms;
using PerformanceMonitorV2.Entities.Concrete.LiveData;
using PerformanceMonitorV2.Management.Concrete;
using PerformanceMonitorV2.WindowsFormsUI.Concrete.PlayerF;

namespace PerformanceMonitorV2.WindowsFormsUI.Concrete.Forms
{
    public partial class CompactDashboard : Form
    {
        #region Fields

        // Timer for hud playing
        private readonly Timer _timer = new Timer { Interval = 1000 };

        // Data source
        private readonly CompactData _data = new CompactData();
        
        #endregion

        #region Constructor

        public CompactDashboard()
        {
            InitializeComponent();
            StartTimer();
        }

        #endregion

        #region Methods

        #region Play Methods

        /// <summary>
        /// Timer starter
        /// </summary>
        private void StartTimer()
        {
            _timer.Tick += Play;
            _timer.Start();
        }

        /// <summary>
        /// Hud updates
        /// </summary>
        /// <param name="sender"> Event object </param>
        /// <param name="e"> Event object </param>
        private void Play(object sender, EventArgs e)
        {
            HudCpu.Value = _data.GetValue(0);
            HudRam.Value = _data.GetValue(1);
            HudDisk.Value = _data.GetValue(2);
            HudNet.Value = _data.GetValue(3);
        }

        #endregion

        #region Control Events

        /// <summary>
        /// Exit from application
        /// </summary>
        /// <param name="sender"> Event object </param>
        /// <param name="e"> Event object </param>
        private void BtnExit_Click(object sender, EventArgs e)
        {
            _timer.Dispose();
            new FormManager().Exit(this);
        }

        /// <summary>
        /// Switch to advanced form
        /// </summary>
        /// <param name="sender"> Event object </param>
        /// <param name="e"> Event object </param>
        private void BtnSwitch_Click(object sender, EventArgs e)
        {
            BtnSwitch.Enabled = false;
            _timer.Dispose();
            Player.Start();
            new FormManager().SwitchForm(this, new MainDashboard());
        }

        #endregion

        #endregion
    }
}
