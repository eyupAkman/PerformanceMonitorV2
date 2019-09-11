namespace PerformanceMonitorV2.WindowsFormsUI.Concrete.Forms
{
    partial class MainDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDashboard));
            this.LeftBar = new System.Windows.Forms.Panel();
            this.BtnMenu = new PerformanceMonitorV2.WindowsFormsUI.Concrete.UserControls.Base.UcButton();
            this.BtnSwitch = new PerformanceMonitorV2.WindowsFormsUI.Concrete.UserControls.Base.UcButton();
            this.BtnExit = new PerformanceMonitorV2.WindowsFormsUI.Concrete.UserControls.Base.UcButton();
            this.BtnNet = new PerformanceMonitorV2.WindowsFormsUI.Concrete.UserControls.Base.UcButton();
            this.BtnDisk = new PerformanceMonitorV2.WindowsFormsUI.Concrete.UserControls.Base.UcButton();
            this.BtnRam = new PerformanceMonitorV2.WindowsFormsUI.Concrete.UserControls.Base.UcButton();
            this.BtnCpu = new PerformanceMonitorV2.WindowsFormsUI.Concrete.UserControls.Base.UcButton();
            this.MainContainer = new System.Windows.Forms.Panel();
            this.PageCpu = new PerformanceMonitorV2.WindowsFormsUI.Concrete.UserControls.Pages.UcPageCpu();
            this.PageRam = new PerformanceMonitorV2.WindowsFormsUI.Concrete.UserControls.Pages.UcPageRam();
            this.PageNet = new PerformanceMonitorV2.WindowsFormsUI.Concrete.UserControls.Pages.UcPageNet();
            this.PageDisk = new PerformanceMonitorV2.WindowsFormsUI.Concrete.UserControls.Pages.UcPageDisk();
            this.LeftBar.SuspendLayout();
            this.MainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftBar
            // 
            this.LeftBar.Controls.Add(this.BtnMenu);
            this.LeftBar.Controls.Add(this.BtnSwitch);
            this.LeftBar.Controls.Add(this.BtnExit);
            this.LeftBar.Controls.Add(this.BtnNet);
            this.LeftBar.Controls.Add(this.BtnDisk);
            this.LeftBar.Controls.Add(this.BtnRam);
            this.LeftBar.Controls.Add(this.BtnCpu);
            this.LeftBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftBar.Location = new System.Drawing.Point(0, 0);
            this.LeftBar.Name = "LeftBar";
            this.LeftBar.Size = new System.Drawing.Size(50, 500);
            this.LeftBar.TabIndex = 0;
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackColor = System.Drawing.Color.Transparent;
            this.BtnMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnMenu.Image = ((System.Drawing.Image)(resources.GetObject("BtnMenu.Image")));
            this.BtnMenu.ImgAct = ((System.Drawing.Image)(resources.GetObject("BtnMenu.ImgAct")));
            this.BtnMenu.Location = new System.Drawing.Point(0, 350);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(50, 50);
            this.BtnMenu.TabIndex = 6;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // BtnSwitch
            // 
            this.BtnSwitch.BackColor = System.Drawing.Color.Transparent;
            this.BtnSwitch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnSwitch.Image = ((System.Drawing.Image)(resources.GetObject("BtnSwitch.Image")));
            this.BtnSwitch.ImgAct = ((System.Drawing.Image)(resources.GetObject("BtnSwitch.ImgAct")));
            this.BtnSwitch.Location = new System.Drawing.Point(0, 400);
            this.BtnSwitch.Name = "BtnSwitch";
            this.BtnSwitch.Size = new System.Drawing.Size(50, 50);
            this.BtnSwitch.TabIndex = 5;
            this.BtnSwitch.Click += new System.EventHandler(this.BtnSwitch_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Transparent;
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.ImgAct = ((System.Drawing.Image)(resources.GetObject("BtnExit.ImgAct")));
            this.BtnExit.Location = new System.Drawing.Point(0, 450);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(50, 50);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnNet
            // 
            this.BtnNet.BackColor = System.Drawing.Color.Transparent;
            this.BtnNet.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnNet.Image = ((System.Drawing.Image)(resources.GetObject("BtnNet.Image")));
            this.BtnNet.ImgAct = ((System.Drawing.Image)(resources.GetObject("BtnNet.ImgAct")));
            this.BtnNet.Location = new System.Drawing.Point(0, 150);
            this.BtnNet.Name = "BtnNet";
            this.BtnNet.Size = new System.Drawing.Size(50, 50);
            this.BtnNet.TabIndex = 3;
            this.BtnNet.Click += new System.EventHandler(this.BtnNet_Click);
            // 
            // BtnDisk
            // 
            this.BtnDisk.BackColor = System.Drawing.Color.Transparent;
            this.BtnDisk.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDisk.Image = ((System.Drawing.Image)(resources.GetObject("BtnDisk.Image")));
            this.BtnDisk.ImgAct = ((System.Drawing.Image)(resources.GetObject("BtnDisk.ImgAct")));
            this.BtnDisk.Location = new System.Drawing.Point(0, 100);
            this.BtnDisk.Name = "BtnDisk";
            this.BtnDisk.Size = new System.Drawing.Size(50, 50);
            this.BtnDisk.TabIndex = 2;
            this.BtnDisk.Click += new System.EventHandler(this.BtnDisk_Click);
            // 
            // BtnRam
            // 
            this.BtnRam.BackColor = System.Drawing.Color.Transparent;
            this.BtnRam.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRam.Image = ((System.Drawing.Image)(resources.GetObject("BtnRam.Image")));
            this.BtnRam.ImgAct = ((System.Drawing.Image)(resources.GetObject("BtnRam.ImgAct")));
            this.BtnRam.Location = new System.Drawing.Point(0, 50);
            this.BtnRam.Name = "BtnRam";
            this.BtnRam.Size = new System.Drawing.Size(50, 50);
            this.BtnRam.TabIndex = 1;
            this.BtnRam.Click += new System.EventHandler(this.BtnRam_Click);
            // 
            // BtnCpu
            // 
            this.BtnCpu.BackColor = System.Drawing.Color.Transparent;
            this.BtnCpu.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCpu.Image = ((System.Drawing.Image)(resources.GetObject("BtnCpu.Image")));
            this.BtnCpu.ImgAct = ((System.Drawing.Image)(resources.GetObject("BtnCpu.ImgAct")));
            this.BtnCpu.Location = new System.Drawing.Point(0, 0);
            this.BtnCpu.Name = "BtnCpu";
            this.BtnCpu.Size = new System.Drawing.Size(50, 50);
            this.BtnCpu.TabIndex = 0;
            this.BtnCpu.Click += new System.EventHandler(this.BtnCpu_Click);
            // 
            // MainContainer
            // 
            this.MainContainer.Controls.Add(this.PageCpu);
            this.MainContainer.Controls.Add(this.PageRam);
            this.MainContainer.Controls.Add(this.PageNet);
            this.MainContainer.Controls.Add(this.PageDisk);
            this.MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContainer.Location = new System.Drawing.Point(50, 0);
            this.MainContainer.Name = "MainContainer";
            this.MainContainer.Size = new System.Drawing.Size(700, 500);
            this.MainContainer.TabIndex = 1;
            // 
            // PageCpu
            // 
            this.PageCpu.BackColor = System.Drawing.Color.Transparent;
            this.PageCpu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PageCpu.Location = new System.Drawing.Point(0, 0);
            this.PageCpu.Name = "PageCpu";
            this.PageCpu.Size = new System.Drawing.Size(700, 500);
            this.PageCpu.TabIndex = 4;
            // 
            // PageRam
            // 
            this.PageRam.BackColor = System.Drawing.Color.Transparent;
            this.PageRam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PageRam.Location = new System.Drawing.Point(0, 0);
            this.PageRam.Name = "PageRam";
            this.PageRam.Size = new System.Drawing.Size(700, 500);
            this.PageRam.TabIndex = 1;
            // 
            // PageNet
            // 
            this.PageNet.BackColor = System.Drawing.Color.Transparent;
            this.PageNet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PageNet.Location = new System.Drawing.Point(0, 0);
            this.PageNet.Name = "PageNet";
            this.PageNet.Size = new System.Drawing.Size(700, 500);
            this.PageNet.TabIndex = 3;
            // 
            // PageDisk
            // 
            this.PageDisk.BackColor = System.Drawing.Color.Transparent;
            this.PageDisk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PageDisk.Location = new System.Drawing.Point(0, 0);
            this.PageDisk.Name = "PageDisk";
            this.PageDisk.Size = new System.Drawing.Size(700, 500);
            this.PageDisk.TabIndex = 2;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.ControlBox = false;
            this.Controls.Add(this.MainContainer);
            this.Controls.Add(this.LeftBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainDashboard";
            this.LeftBar.ResumeLayout(false);
            this.MainContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftBar;
        private UserControls.Base.UcButton BtnMenu;
        private UserControls.Base.UcButton BtnSwitch;
        private UserControls.Base.UcButton BtnExit;
        private UserControls.Base.UcButton BtnNet;
        private UserControls.Base.UcButton BtnDisk;
        private UserControls.Base.UcButton BtnRam;
        private UserControls.Base.UcButton BtnCpu;
        private System.Windows.Forms.Panel MainContainer;
        private UserControls.Pages.UcPageNet PageNet;
        private UserControls.Pages.UcPageDisk PageDisk;
        private UserControls.Pages.UcPageRam PageRam;
        private UserControls.Pages.UcPageCpu PageCpu;
    }
}