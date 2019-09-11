namespace PerformanceMonitorV2.WindowsFormsUI.Concrete.UserControls.Pages
{
    partial class UcPageDisk
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcPageDisk));
            this.InfoCard = new PerformanceMonitorV2.WindowsFormsUI.Concrete.UserControls.Base.UcInfo();
            this.Chart = new PerformanceMonitorV2.WindowsFormsUI.Concrete.UserControls.Base.UcChart();
            this.Hud = new PerformanceMonitorV2.WindowsFormsUI.Concrete.UserControls.Base.UcHud();
            this.iconBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // InfoCard
            // 
            this.InfoCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.InfoCard.Dock = System.Windows.Forms.DockStyle.Left;
            this.InfoCard.Location = new System.Drawing.Point(0, 0);
            this.InfoCard.Name = "InfoCard";
            this.InfoCard.Size = new System.Drawing.Size(200, 500);
            this.InfoCard.TabIndex = 0;
            // 
            // Chart
            // 
            this.Chart.BackColor = System.Drawing.Color.Transparent;
            this.Chart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Chart.IsPercent = true;
            this.Chart.Location = new System.Drawing.Point(200, 150);
            this.Chart.Maximum = 100D;
            this.Chart.Name = "Chart";
            this.Chart.Size = new System.Drawing.Size(500, 350);
            this.Chart.TabIndex = 1;
            // 
            // Hud
            // 
            this.Hud.BackColor = System.Drawing.Color.Transparent;
            this.Hud.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.Hud.BottomLabel = "Storage";
            this.Hud.ForeColor2 = System.Drawing.Color.White;
            this.Hud.IsPercent = true;
            this.Hud.Location = new System.Drawing.Point(25, 332);
            this.Hud.Maximum = 100;
            this.Hud.Name = "Hud";
            this.Hud.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.Hud.ProgressColor = System.Drawing.Color.White;
            this.Hud.Size = new System.Drawing.Size(150, 150);
            this.Hud.TabIndex = 2;
            this.Hud.TopLabel = "Activity";
            this.Hud.Value = 100F;
            // 
            // iconBox
            // 
            this.iconBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.iconBox.Image = ((System.Drawing.Image)(resources.GetObject("iconBox.Image")));
            this.iconBox.Location = new System.Drawing.Point(30, 21);
            this.iconBox.Margin = new System.Windows.Forms.Padding(0);
            this.iconBox.Name = "iconBox";
            this.iconBox.Size = new System.Drawing.Size(140, 140);
            this.iconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconBox.TabIndex = 4;
            this.iconBox.TabStop = false;
            // 
            // UcPageDisk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.iconBox);
            this.Controls.Add(this.Hud);
            this.Controls.Add(this.Chart);
            this.Controls.Add(this.InfoCard);
            this.Name = "UcPageDisk";
            this.Size = new System.Drawing.Size(700, 500);
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Base.UcInfo InfoCard;
        private Base.UcChart Chart;
        private Base.UcHud Hud;
        private System.Windows.Forms.PictureBox iconBox;
    }
}
