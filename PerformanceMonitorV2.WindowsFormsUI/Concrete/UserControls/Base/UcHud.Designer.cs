namespace PerformanceMonitorV2.WindowsFormsUI.Concrete.UserControls.Base
{
    partial class UcHud
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
            this.LabelBottom = new System.Windows.Forms.Label();
            this.LabelTop = new System.Windows.Forms.Label();
            this.Hud = new CircularProgressBar.CircularProgressBar();
            this.SuspendLayout();
            // 
            // LabelBottom
            // 
            this.LabelBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelBottom.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBottom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.LabelBottom.Location = new System.Drawing.Point(35, 90);
            this.LabelBottom.Name = "LabelBottom";
            this.LabelBottom.Size = new System.Drawing.Size(80, 20);
            this.LabelBottom.TabIndex = 5;
            this.LabelBottom.Text = "Label";
            this.LabelBottom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelTop
            // 
            this.LabelTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelTop.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.LabelTop.Location = new System.Drawing.Point(35, 40);
            this.LabelTop.Name = "LabelTop";
            this.LabelTop.Size = new System.Drawing.Size(80, 20);
            this.LabelTop.TabIndex = 4;
            this.LabelTop.Text = "Label";
            this.LabelTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Hud
            // 
            this.Hud.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.SinusoidalEaseOut;
            this.Hud.AnimationSpeed = 500;
            this.Hud.BackColor = System.Drawing.Color.Transparent;
            this.Hud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Hud.Font = new System.Drawing.Font("Nirmala UI", 24F);
            this.Hud.ForeColor = System.Drawing.Color.White;
            this.Hud.InnerColor = System.Drawing.Color.Transparent;
            this.Hud.InnerMargin = 0;
            this.Hud.InnerWidth = -1;
            this.Hud.Location = new System.Drawing.Point(0, 0);
            this.Hud.Margin = new System.Windows.Forms.Padding(0);
            this.Hud.MarqueeAnimationSpeed = 2000;
            this.Hud.Name = "Hud";
            this.Hud.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.Hud.OuterMargin = 0;
            this.Hud.OuterWidth = -15;
            this.Hud.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.Hud.ProgressWidth = 4;
            this.Hud.SecondaryFont = new System.Drawing.Font("Nirmala UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hud.Size = new System.Drawing.Size(150, 150);
            this.Hud.StartAngle = 270;
            this.Hud.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Hud.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Hud.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.Hud.SubscriptText = "";
            this.Hud.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Hud.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.Hud.SuperscriptText = "";
            this.Hud.TabIndex = 3;
            this.Hud.Text = "100%";
            this.Hud.TextMargin = new System.Windows.Forms.Padding(-1, 0, 0, 0);
            this.Hud.Value = 100;
            // 
            // UcHud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.LabelBottom);
            this.Controls.Add(this.LabelTop);
            this.Controls.Add(this.Hud);
            this.Name = "UcHud";
            this.ResumeLayout(false);

        }

        #endregion

        protected internal System.Windows.Forms.Label LabelBottom;
        protected internal System.Windows.Forms.Label LabelTop;
        protected internal CircularProgressBar.CircularProgressBar Hud;
    }
}
