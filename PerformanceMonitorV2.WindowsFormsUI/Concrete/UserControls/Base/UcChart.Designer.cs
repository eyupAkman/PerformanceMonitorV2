namespace PerformanceMonitorV2.WindowsFormsUI.Concrete.UserControls.Base
{
    partial class UcChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.LblD = new System.Windows.Forms.Label();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnl = new System.Windows.Forms.Panel();
            this.LblR = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // LblD
            // 
            this.LblD.AutoSize = true;
            this.LblD.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblD.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LblD.Location = new System.Drawing.Point(343, 0);
            this.LblD.Name = "LblD";
            this.LblD.Size = new System.Drawing.Size(125, 13);
            this.LblD.TabIndex = 7;
            this.LblD.Text = "Double Left Click to 3D";
            this.LblD.Visible = false;
            // 
            // Chart
            // 
            this.Chart.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.Crossing = 1.7976931348623157E+308D;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Nirmala UI", 9F);
            chartArea1.AxisX.LineWidth = 0;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX.Maximum = 30D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Crossing = 1.7976931348623157E+308D;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            chartArea1.AxisY.LabelStyle.IsEndLabelVisible = false;
            chartArea1.AxisY.LineWidth = 0;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.AxisY.Maximum = 100D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.BorderWidth = 0;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 100F;
            chartArea1.InnerPlotPosition.Width = 100F;
            chartArea1.IsSameFontSizeForAllAxes = true;
            chartArea1.Name = "0";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 100F;
            chartArea1.Position.Width = 100F;
            this.Chart.ChartAreas.Add(chartArea1);
            this.Chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.BorderWidth = 0;
            legend1.DockedToChartArea = "0";
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            legend1.Enabled = false;
            legend1.Font = new System.Drawing.Font("Nirmala UI", 8F);
            legend1.ForeColor = System.Drawing.Color.Silver;
            legend1.InterlacedRowsColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            legend1.IsEquallySpacedItems = true;
            legend1.IsTextAutoFit = false;
            legend1.Name = "0";
            legend1.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Tall;
            this.Chart.Legends.Add(legend1);
            this.Chart.Location = new System.Drawing.Point(0, 0);
            this.Chart.Name = "Chart";
            this.Chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.Chart.Size = new System.Drawing.Size(500, 350);
            this.Chart.TabIndex = 8;
            this.Chart.Text = "chart1";
            this.Chart.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DoubleClick);
            this.Chart.MouseEnter += new System.EventHandler(this.Chart_MouseEnter);
            this.Chart.MouseLeave += new System.EventHandler(this.Chart_MouseLeave);
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl.Location = new System.Drawing.Point(0, 0);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(500, 1);
            this.pnl.TabIndex = 9;
            // 
            // LblR
            // 
            this.LblR.AutoSize = true;
            this.LblR.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblR.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LblR.Location = new System.Drawing.Point(343, 14);
            this.LblR.Name = "LblR";
            this.LblR.Size = new System.Drawing.Size(153, 13);
            this.LblR.TabIndex = 10;
            this.LblR.Text = "Double Right Click to Range";
            this.LblR.Visible = false;
            // 
            // UcChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.LblR);
            this.Controls.Add(this.LblD);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.Chart);
            this.Name = "UcChart";
            this.Size = new System.Drawing.Size(500, 350);
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblD;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Label LblR;
    }
}
