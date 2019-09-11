using System;
using System.Drawing;
using System.Windows.Forms;
using PerformanceMonitorV2.Entities.Concrete.FixedData;

namespace PerformanceMonitorV2.WindowsFormsUI.Concrete.UserControls.Pages
{
    public partial class UcPageCpuDetail : UserControl
    {
        #region Fields

        // Store active page s
        private string _active = "";

        // Button names
        private enum Buttons
        {
            BtnNam,
            BtnPhy,
            BtnPer,
            BtnArc,
            BtnCor,
            BtnCac,
            BtnFea
        }

        #endregion

        #region Constructor

        public UcPageCpuDetail()
        {
            InitializeComponent();
            WriteLabels();
            WhenClick(Buttons.BtnNam);
        }

        #endregion

        #region Methods

        #region Setups

        /// <summary>
        /// Write all cpu details
        /// </summary>
        private void WriteLabels()
        {
            var d = new CpuSpecs().GetDetails();
            if (d == null) return;
            lblBasBox.Text = d.BaseClock;
            lblBioBox.Text = d.BiosNames;
            lblBooBox.Text = d.Boost;
            lblCloBox.Text = d.Clock;
            lblCodBox.Text = d.CodeName;
            lblCorBox.Text = d.Cores;
            lblDieBox.Text = d.DieSize;
            lblFamBox.Text = d.Family;
            lblFouBox.Text = d.Foundry;
            lblFulbox.Text = d.FullName;
            lblGenBox.Text = d.Generation;
            lblGpuBox.Text = d.Gpu;
            lblL1Box.Text = d.L1;
            lblL2Box.Text = d.L2;
            lblL3Box.Text = d.L3;
            lblLitBox.Text = d.Lithography;
            lblManBox.Text = d.Manufacturer;
            lblMarBox.Text = d.Market;
            lblMaxBox.Text = d.MaxTemp;
            lblMemBox.Text = d.Memory;
            lblModBox.Text = d.Model;
            lblMulBox.Text = d.Multiplier;
            lblPacBox.Text = d.Package;
            lblParBox.Text = d.Part;
            lblRelBox.Text = d.Released;
            lblSerBox.Text = d.Series;
            lblSmpBox.Text = d.SmpCpu;
            lblSocBox.Text = d.Socket;
            lblStaBox.Text = d.Status;
            lblTdpBox.Text = d.Tdp;
            lblThrBox.Text = d.Threads;
            lblTraBox.Text = d.Transistors;
            lblUnlBox.Text = d.Unlocked;
            lblVolBox.Text = d.Voltage;
            var split = d.Features.Split(' ');
            foreach (var s in split)
            {
                featuresContainer.Controls.Add(GetLabel(s));
            }
        }

        /// <summary>
        /// Get label for cpu features
        /// </summary>
        /// <param name="s"> Feature string </param>
        /// <returns> Return customized label </returns>
        private Label GetLabel(string s)
        {
            return new Label { Text = $@"✓ {s}", Margin = new Padding(5) };
        }

        /// <summary>
        /// Set button color and page actions
        /// </summary>
        /// <param name="button"> Need a button </param>
        private void WhenClick(Buttons button)
        {
            if (_active.Equals(button.ToString().Substring(3))) return;
            SetButtonColor(button);
            SetPage(button);
        }

        /// <summary>
        /// Set button color
        /// </summary>
        /// <param name="button"> Button from top method </param>
        private void SetButtonColor(Buttons button)
        {
            foreach (Control control in HeaderTab.Controls)
            {
                if (control.Name.Substring(3).Equals(button.ToString().Substring(3)))
                {
                    control.BackColor = Color.FromArgb(24, 24, 34);
                    _active = control.Name;
                }
                else
                {
                    control.BackColor = Color.Transparent;
                }
            }
        }

        /// <summary>
        /// Page bring to front
        /// </summary>
        /// <param name="button"> Button from top method </param>
        private void SetPage(Buttons button)
        {
            foreach (Control control in MainContainer.Controls)
            {
                if (control.Name.Substring(3).Equals(button.ToString().Substring(3))) control.BringToFront();
            }
        }

        #endregion

        #region Events

        /// <summary>
        /// Close page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
        }

        private void BtnNam_Click(object sender, EventArgs e)
        {
            WhenClick(Buttons.BtnNam);
        }

        private void BtnPhy_Click(object sender, EventArgs e)
        {
            WhenClick(Buttons.BtnPhy);
        }

        private void BtnPer_Click(object sender, EventArgs e)
        {
            WhenClick(Buttons.BtnPer);
        }

        private void BtnArc_Click(object sender, EventArgs e)
        {
            WhenClick(Buttons.BtnArc);
        }

        private void BtnCor_Click(object sender, EventArgs e)
        {
            WhenClick(Buttons.BtnCor);
        }

        private void BtnCac_Click(object sender, EventArgs e)
        {
            WhenClick(Buttons.BtnCac);
        }

        private void BtnFea_Click(object sender, EventArgs e)
        {
            WhenClick(Buttons.BtnFea);
        }

        #endregion

        #endregion
    }
}
