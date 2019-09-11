namespace PerformanceMonitorV2.WindowsFormsUI.Concrete.Forms
{
    partial class CompactDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompactDashboard));
            this.LeftBar = new System.Windows.Forms.Panel();
            this.BtnExit = new PerformanceMonitorV2.WindowsFormsUI.Concrete.UserControls.Base.UcButton();
            this.BtnSwitch = new PerformanceMonitorV2.WindowsFormsUI.Concrete.UserControls.Base.UcButton();
            this.LeftPadding = new System.Windows.Forms.Panel();
            this.HudContainer = new System.Windows.Forms.Panel();
            this.RightPadding = new System.Windows.Forms.Panel();
            this.HudCpu = new PerformanceMonitorV2.WindowsFormsUI.Concrete.UserControls.Base.UcHud();
            this.HudRam = new PerformanceMonitorV2.WindowsFormsUI.Concrete.UserControls.Base.UcHud();
            this.HudDisk = new PerformanceMonitorV2.WindowsFormsUI.Concrete.UserControls.Base.UcHud();
            this.HudNet = new PerformanceMonitorV2.WindowsFormsUI.Concrete.UserControls.Base.UcHud();
            this.LeftBar.SuspendLayout();
            this.HudContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftBar
            // 
            this.LeftBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.LeftBar.Controls.Add(this.BtnExit);
            this.LeftBar.Controls.Add(this.BtnSwitch);
            this.LeftBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftBar.ForeColor = System.Drawing.Color.White;
            this.LeftBar.Location = new System.Drawing.Point(0, 0);
            this.LeftBar.Name = "LeftBar";
            this.LeftBar.Size = new System.Drawing.Size(30, 150);
            this.LeftBar.TabIndex = 0;
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Transparent;
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.ImgAct = ((System.Drawing.Image)(resources.GetObject("BtnExit.ImgAct")));
            this.BtnExit.Location = new System.Drawing.Point(0, 120);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(30, 30);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnSwitch
            // 
            this.BtnSwitch.BackColor = System.Drawing.Color.Transparent;
            this.BtnSwitch.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSwitch.Image = ((System.Drawing.Image)(resources.GetObject("BtnSwitch.Image")));
            this.BtnSwitch.ImgAct = ((System.Drawing.Image)(resources.GetObject("BtnSwitch.ImgAct")));
            this.BtnSwitch.Location = new System.Drawing.Point(0, 0);
            this.BtnSwitch.Name = "BtnSwitch";
            this.BtnSwitch.Size = new System.Drawing.Size(30, 30);
            this.BtnSwitch.TabIndex = 0;
            this.BtnSwitch.Click += new System.EventHandler(this.BtnSwitch_Click);
            // 
            // LeftPadding
            // 
            this.LeftPadding.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPadding.Location = new System.Drawing.Point(30, 0);
            this.LeftPadding.Name = "LeftPadding";
            this.LeftPadding.Size = new System.Drawing.Size(10, 150);
            this.LeftPadding.TabIndex = 1;
            // 
            // HudContainer
            // 
            this.HudContainer.Controls.Add(this.HudNet);
            this.HudContainer.Controls.Add(this.HudDisk);
            this.HudContainer.Controls.Add(this.HudRam);
            this.HudContainer.Controls.Add(this.HudCpu);
            this.HudContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.HudContainer.Location = new System.Drawing.Point(40, 0);
            this.HudContainer.Name = "HudContainer";
            this.HudContainer.Size = new System.Drawing.Size(600, 150);
            this.HudContainer.TabIndex = 1;
            // 
            // RightPadding
            // 
            this.RightPadding.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPadding.Location = new System.Drawing.Point(640, 0);
            this.RightPadding.Name = "RightPadding";
            this.RightPadding.Size = new System.Drawing.Size(10, 150);
            this.RightPadding.TabIndex = 1;
            // 
            // HudCpu
            // 
            this.HudCpu.BackColor = System.Drawing.Color.Transparent;
            this.HudCpu.BackColor2 = System.Drawing.Color.Transparent;
            this.HudCpu.BottomLabel = "Cpu";
            this.HudCpu.Dock = System.Windows.Forms.DockStyle.Left;
            this.HudCpu.ForeColor2 = System.Drawing.Color.White;
            this.HudCpu.IsPercent = true;
            this.HudCpu.Location = new System.Drawing.Point(0, 0);
            this.HudCpu.Maximum = 100;
            this.HudCpu.Name = "HudCpu";
            this.HudCpu.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.HudCpu.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.HudCpu.Size = new System.Drawing.Size(150, 150);
            this.HudCpu.TabIndex = 0;
            this.HudCpu.TopLabel = "Activity";
            this.HudCpu.Value = 100F;
            // 
            // HudRam
            // 
            this.HudRam.BackColor = System.Drawing.Color.Transparent;
            this.HudRam.BackColor2 = System.Drawing.Color.Transparent;
            this.HudRam.BottomLabel = "Ram";
            this.HudRam.Dock = System.Windows.Forms.DockStyle.Left;
            this.HudRam.ForeColor2 = System.Drawing.Color.White;
            this.HudRam.IsPercent = true;
            this.HudRam.Location = new System.Drawing.Point(150, 0);
            this.HudRam.Maximum = 100;
            this.HudRam.Name = "HudRam";
            this.HudRam.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.HudRam.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.HudRam.Size = new System.Drawing.Size(150, 150);
            this.HudRam.TabIndex = 1;
            this.HudRam.TopLabel = "Usage";
            this.HudRam.Value = 100F;
            // 
            // HudDisk
            // 
            this.HudDisk.BackColor = System.Drawing.Color.Transparent;
            this.HudDisk.BackColor2 = System.Drawing.Color.Transparent;
            this.HudDisk.BottomLabel = "Storage";
            this.HudDisk.Dock = System.Windows.Forms.DockStyle.Left;
            this.HudDisk.ForeColor2 = System.Drawing.Color.White;
            this.HudDisk.IsPercent = true;
            this.HudDisk.Location = new System.Drawing.Point(300, 0);
            this.HudDisk.Maximum = 100;
            this.HudDisk.Name = "HudDisk";
            this.HudDisk.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.HudDisk.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.HudDisk.Size = new System.Drawing.Size(150, 150);
            this.HudDisk.TabIndex = 2;
            this.HudDisk.TopLabel = "Activity";
            this.HudDisk.Value = 100F;
            // 
            // HudNet
            // 
            this.HudNet.BackColor = System.Drawing.Color.Transparent;
            this.HudNet.BackColor2 = System.Drawing.Color.Transparent;
            this.HudNet.BottomLabel = "Network";
            this.HudNet.Dock = System.Windows.Forms.DockStyle.Left;
            this.HudNet.ForeColor2 = System.Drawing.Color.White;
            this.HudNet.IsPercent = false;
            this.HudNet.Location = new System.Drawing.Point(450, 0);
            this.HudNet.Maximum = 100;
            this.HudNet.Name = "HudNet";
            this.HudNet.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.HudNet.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.HudNet.Size = new System.Drawing.Size(150, 150);
            this.HudNet.TabIndex = 3;
            this.HudNet.TopLabel = "Mbps";
            this.HudNet.Value = 100F;
            // 
            // CompactDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(650, 150);
            this.ControlBox = false;
            this.Controls.Add(this.HudContainer);
            this.Controls.Add(this.LeftPadding);
            this.Controls.Add(this.LeftBar);
            this.Controls.Add(this.RightPadding);
            this.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CompactDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompactDashboard";
            this.LeftBar.ResumeLayout(false);
            this.HudContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftBar;
        private UserControls.Base.UcButton BtnExit;
        private UserControls.Base.UcButton BtnSwitch;
        private System.Windows.Forms.Panel LeftPadding;
        private System.Windows.Forms.Panel HudContainer;
        private System.Windows.Forms.Panel RightPadding;
        private UserControls.Base.UcHud HudCpu;
        private UserControls.Base.UcHud HudNet;
        private UserControls.Base.UcHud HudDisk;
        private UserControls.Base.UcHud HudRam;
    }
}