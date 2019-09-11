using System;
using System.Drawing;
using System.Windows.Forms;
using PerformanceMonitorV2.Management.Concrete;
using PerformanceMonitorV2.WindowsFormsUI.Concrete.PlayerF;

namespace PerformanceMonitorV2.WindowsFormsUI.Concrete.Forms
{
    public partial class MainDashboard : Form
    {
        #region Fields
        
        // Store buttons
        private enum Buttons
        {
            BtnCpu,
            BtnRam,
            BtnDisk,
            BtnNet
        }

        // Store active button and page name
        private string _active = "";

        #endregion

        #region Constructor

        public MainDashboard()
        {
            InitializeComponent();
            FirstStart();
        }

        #endregion

        #region Methods

        #region Actions

        // Setup for first start
        private void FirstStart()
        {
            WhenClick(Buttons.BtnCpu);
        }

        /// <summary>
        /// Actions when clicked
        /// </summary>
        /// <param name="button"> Needs a button for work </param>
        private void WhenClick(Buttons button)
        {
            if (_active.Equals(button.ToString().Substring(3))) return;
            SetPlayer(button);
            SetButtonColor(button);
            SetPage(button);
        }

        /// <summary>
        /// Player setup
        /// </summary>
        /// <param name="button"> Needs a button for work </param>
        private void SetPlayer(Buttons button)
        {
            switch (button)
            {
                case Buttons.BtnCpu:
                    PageCpu.SetPlayer();
                    break;
                case Buttons.BtnRam:
                    PageRam.SetPlayer();
                    break;
                case Buttons.BtnDisk:
                    PageDisk.SetPlayer();
                    break;
                case Buttons.BtnNet:
                    PageNet.SetPlayer();
                    break;
                default:
                    PageCpu.SetPlayer();
                    break;
            }
        }

        /// <summary>
        /// Set active button color
        /// </summary>
        /// <param name="button"></param>
        private void SetButtonColor(Buttons button)
        {
            foreach (Control control in LeftBar.Controls)
            {
                if (control.Name.Substring(3).Equals(button.ToString().Substring(3)))
                {
                    control.BackColor = Color.FromArgb(0, 236, 236);
                    _active = control.Name;
                }
                else
                {
                    control.BackColor = Color.Transparent;
                }
            }
        }

        /// <summary>
        /// Active page brings to front
        /// </summary>
        /// <param name="button"></param>
        private void SetPage(Buttons button)
        {
            foreach (Control control in MainContainer.Controls)
            {
                if (control.Name.Substring(4).Equals(button.ToString().Substring(3))) control.BringToFront();
            }
        }

        #endregion

        #region Events

        private void BtnCpu_Click(object sender, EventArgs e)
        {
            WhenClick(Buttons.BtnCpu);
        }

        private void BtnRam_Click(object sender, EventArgs e)
        {
            WhenClick(Buttons.BtnRam);
        }

        private void BtnDisk_Click(object sender, EventArgs e)
        {
            WhenClick(Buttons.BtnDisk);
        }

        private void BtnNet_Click(object sender, EventArgs e)
        {
            WhenClick(Buttons.BtnNet);
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
        }

        private void BtnSwitch_Click(object sender, EventArgs e)
        {
            BtnSwitch.Enabled = false;
            Player.Stop();
            new FormManager().SwitchForm(this, new CompactDashboard());
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            new FormManager().Exit(this);
        }

        #endregion

        #endregion
    }
}
