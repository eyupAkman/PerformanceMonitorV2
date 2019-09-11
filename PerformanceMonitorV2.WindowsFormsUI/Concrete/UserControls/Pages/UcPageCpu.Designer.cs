namespace PerformanceMonitorV2.WindowsFormsUI.Concrete.UserControls.Pages
{
    partial class UcPageCpu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcPageCpu));
            this.iconBox = new System.Windows.Forms.PictureBox();
            this.lblMan = new System.Windows.Forms.Label();
            this.lblManBox = new System.Windows.Forms.Label();
            this.lblFamBox = new System.Windows.Forms.Label();
            this.lblFam = new System.Windows.Forms.Label();
            this.lblModBox = new System.Windows.Forms.Label();
            this.lblMod = new System.Windows.Forms.Label();
            this.lblCloBox = new System.Windows.Forms.Label();
            this.lblClo = new System.Windows.Forms.Label();
            this.lblCorBox = new System.Windows.Forms.Label();
            this.lblCor = new System.Windows.Forms.Label();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Hud = new PerformanceMonitorV2.WindowsFormsUI.Concrete.UserControls.Base.UcHud();
            this.Chart = new PerformanceMonitorV2.WindowsFormsUI.Concrete.UserControls.Base.UcChart();
            this.InfoCard = new PerformanceMonitorV2.WindowsFormsUI.Concrete.UserControls.Base.UcInfo();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).BeginInit();
            this.pnlDetails.SuspendLayout();
            this.SuspendLayout();
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
            this.iconBox.TabIndex = 3;
            this.iconBox.TabStop = false;
            this.iconBox.Click += new System.EventHandler(this.MoreDetails);
            // 
            // lblMan
            // 
            this.lblMan.AutoSize = true;
            this.lblMan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.lblMan.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblMan.Location = new System.Drawing.Point(-3, 0);
            this.lblMan.Name = "lblMan";
            this.lblMan.Size = new System.Drawing.Size(77, 13);
            this.lblMan.TabIndex = 4;
            this.lblMan.Text = "Manufacturer";
            this.lblMan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblManBox
            // 
            this.lblManBox.AutoSize = true;
            this.lblManBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.lblManBox.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManBox.ForeColor = System.Drawing.Color.White;
            this.lblManBox.Location = new System.Drawing.Point(-4, 13);
            this.lblManBox.Name = "lblManBox";
            this.lblManBox.Size = new System.Drawing.Size(43, 21);
            this.lblManBox.TabIndex = 5;
            this.lblManBox.Text = "label";
            this.lblManBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFamBox
            // 
            this.lblFamBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.lblFamBox.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFamBox.ForeColor = System.Drawing.Color.White;
            this.lblFamBox.Location = new System.Drawing.Point(60, 13);
            this.lblFamBox.Name = "lblFamBox";
            this.lblFamBox.Size = new System.Drawing.Size(81, 21);
            this.lblFamBox.TabIndex = 7;
            this.lblFamBox.Text = "label";
            this.lblFamBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFam
            // 
            this.lblFam.AutoSize = true;
            this.lblFam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.lblFam.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblFam.Location = new System.Drawing.Point(102, 0);
            this.lblFam.Name = "lblFam";
            this.lblFam.Size = new System.Drawing.Size(39, 13);
            this.lblFam.TabIndex = 6;
            this.lblFam.Text = "Family";
            this.lblFam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblModBox
            // 
            this.lblModBox.AutoSize = true;
            this.lblModBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.lblModBox.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModBox.ForeColor = System.Drawing.Color.White;
            this.lblModBox.Location = new System.Drawing.Point(-4, 53);
            this.lblModBox.Name = "lblModBox";
            this.lblModBox.Size = new System.Drawing.Size(43, 21);
            this.lblModBox.TabIndex = 9;
            this.lblModBox.Text = "label";
            this.lblModBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMod
            // 
            this.lblMod.AutoSize = true;
            this.lblMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.lblMod.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblMod.Location = new System.Drawing.Point(-3, 40);
            this.lblMod.Name = "lblMod";
            this.lblMod.Size = new System.Drawing.Size(40, 13);
            this.lblMod.TabIndex = 8;
            this.lblMod.Text = "Model";
            this.lblMod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCloBox
            // 
            this.lblCloBox.AutoSize = true;
            this.lblCloBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.lblCloBox.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloBox.ForeColor = System.Drawing.Color.White;
            this.lblCloBox.Location = new System.Drawing.Point(-4, 133);
            this.lblCloBox.Name = "lblCloBox";
            this.lblCloBox.Size = new System.Drawing.Size(43, 21);
            this.lblCloBox.TabIndex = 13;
            this.lblCloBox.Text = "label";
            this.lblCloBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblClo
            // 
            this.lblClo.AutoSize = true;
            this.lblClo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.lblClo.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblClo.Location = new System.Drawing.Point(-3, 120);
            this.lblClo.Name = "lblClo";
            this.lblClo.Size = new System.Drawing.Size(75, 13);
            this.lblClo.TabIndex = 12;
            this.lblClo.Text = "Clock / Boost";
            this.lblClo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCorBox
            // 
            this.lblCorBox.AutoSize = true;
            this.lblCorBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.lblCorBox.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorBox.ForeColor = System.Drawing.Color.White;
            this.lblCorBox.Location = new System.Drawing.Point(-4, 93);
            this.lblCorBox.Name = "lblCorBox";
            this.lblCorBox.Size = new System.Drawing.Size(43, 21);
            this.lblCorBox.TabIndex = 15;
            this.lblCorBox.Text = "label";
            this.lblCorBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.lblCor.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblCor.Location = new System.Drawing.Point(-3, 80);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(86, 13);
            this.lblCor.TabIndex = 14;
            this.lblCor.Text = "Cores / Threads";
            this.lblCor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlDetails
            // 
            this.pnlDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.pnlDetails.Controls.Add(this.label1);
            this.pnlDetails.Controls.Add(this.lblMan);
            this.pnlDetails.Controls.Add(this.lblManBox);
            this.pnlDetails.Controls.Add(this.lblCorBox);
            this.pnlDetails.Controls.Add(this.lblFam);
            this.pnlDetails.Controls.Add(this.lblCor);
            this.pnlDetails.Controls.Add(this.lblFamBox);
            this.pnlDetails.Controls.Add(this.lblCloBox);
            this.pnlDetails.Controls.Add(this.lblMod);
            this.pnlDetails.Controls.Add(this.lblClo);
            this.pnlDetails.Controls.Add(this.lblModBox);
            this.pnlDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDetails.Location = new System.Drawing.Point(30, 163);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(140, 178);
            this.pnlDetails.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(0, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Click here for more details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.MoreDetails);
            // 
            // Hud
            // 
            this.Hud.BackColor = System.Drawing.Color.Transparent;
            this.Hud.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.Hud.BottomLabel = "Cpu";
            this.Hud.ForeColor2 = System.Drawing.Color.White;
            this.Hud.IsPercent = true;
            this.Hud.Location = new System.Drawing.Point(25, 332);
            this.Hud.Maximum = 100;
            this.Hud.Name = "Hud";
            this.Hud.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.Hud.ProgressColor = System.Drawing.Color.White;
            this.Hud.Size = new System.Drawing.Size(150, 150);
            this.Hud.TabIndex = 16;
            this.Hud.TopLabel = "Activity";
            this.Hud.Value = 100F;
            // 
            // Chart
            // 
            this.Chart.BackColor = System.Drawing.Color.Transparent;
            this.Chart.IsPercent = true;
            this.Chart.Location = new System.Drawing.Point(200, 150);
            this.Chart.Maximum = 100D;
            this.Chart.Name = "Chart";
            this.Chart.Size = new System.Drawing.Size(500, 350);
            this.Chart.TabIndex = 2;
            // 
            // InfoCard
            // 
            this.InfoCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.InfoCard.Location = new System.Drawing.Point(0, 0);
            this.InfoCard.Name = "InfoCard";
            this.InfoCard.Size = new System.Drawing.Size(200, 500);
            this.InfoCard.TabIndex = 1;
            // 
            // UcPageCpu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.Hud);
            this.Controls.Add(this.iconBox);
            this.Controls.Add(this.Chart);
            this.Controls.Add(this.InfoCard);
            this.Name = "UcPageCpu";
            this.Size = new System.Drawing.Size(700, 500);
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).EndInit();
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Base.UcInfo InfoCard;
        private Base.UcChart Chart;
        private System.Windows.Forms.PictureBox iconBox;
        private System.Windows.Forms.Label lblMan;
        private System.Windows.Forms.Label lblManBox;
        private System.Windows.Forms.Label lblFamBox;
        private System.Windows.Forms.Label lblFam;
        private System.Windows.Forms.Label lblModBox;
        private System.Windows.Forms.Label lblMod;
        private System.Windows.Forms.Label lblCloBox;
        private System.Windows.Forms.Label lblClo;
        private System.Windows.Forms.Label lblCorBox;
        private System.Windows.Forms.Label lblCor;
        private Base.UcHud Hud;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Label label1;
    }
}
