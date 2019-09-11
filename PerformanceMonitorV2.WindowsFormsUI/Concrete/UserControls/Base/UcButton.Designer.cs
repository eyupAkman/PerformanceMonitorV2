namespace PerformanceMonitorV2.WindowsFormsUI.Concrete.UserControls.Base
{
    partial class UcButton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcButton));
            this.Box = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Box)).BeginInit();
            this.SuspendLayout();
            // 
            // Box
            // 
            this.Box.Image = ((System.Drawing.Image)(resources.GetObject("Box.Image")));
            this.Box.Location = new System.Drawing.Point(0, 0);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(100, 100);
            this.Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Box.TabIndex = 2;
            this.Box.TabStop = false;
            this.Box.MouseEnter += new System.EventHandler(this.UcButton_MouseEnter);
            this.Box.MouseLeave += new System.EventHandler(this.UcButton_MouseLeave);
            // 
            // UcButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Box);
            this.Name = "UcButton";
            this.Size = new System.Drawing.Size(100, 100);
            this.SizeChanged += new System.EventHandler(this.UcButton_SizeChanged);
            this.MouseEnter += new System.EventHandler(this.UcButton_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UcButton_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.Box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox Box;
    }
}
