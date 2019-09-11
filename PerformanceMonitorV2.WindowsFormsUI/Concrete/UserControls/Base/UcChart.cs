using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PerformanceMonitorV2.WindowsFormsUI.Concrete.UserControls.Base
{
    public partial class UcChart : UserControl
    {
        #region Fields

        // Player handler container
        private Action _action;

        // Temporary value container
        private float _value;

        // Series index container
        private int _index;

        // Series name container
        private string _name;

        // Player switcher container
        private bool _isPercent;

        #endregion

        #region Constructor

        public UcChart()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Reference used to check the maximum value
        /// </summary>
        [DisplayName("Chart Maximum"), Category("Special")]
        public double Maximum
        {
            get => Chart.ChartAreas[0].Axes[1].Maximum;
            set => Chart.ChartAreas[0].Axes[1].Maximum = value;
        }

        /// <summary>
        /// Player handler switcher
        /// </summary>
        [DisplayName("Is Percentage ?"), Category("Special")]
        public bool IsPercent
        {
            get => _isPercent;
            set
            {
                _isPercent = value;
                _action = _isPercent ? (Action)Update1 : Update2;
            }
        }

        #endregion

        #region Methods

        #region Setups

        /// <summary>
        /// Adding series into chart
        /// </summary>
        /// <param name="list"> Series name list </param>
        public void AddSeries(List<string> list)
        {
            foreach (var name in list)
            {
                Chart.Series.Add(GetSeries(name));
                for (int i = 0; i < 31; i++)
                {
                    Chart.Series[list.IndexOf(name)].Points.AddY(-5);
                }
            }
        }

        /// <summary>
        /// Return a customized series
        /// </summary>
        /// <param name="name"> Series name </param>
        /// <returns> Return custom series </returns>
        private Series GetSeries(string name)
        {
            var sr = new Series { Name = name, ChartType = SeriesChartType.FastLine, ToolTip = name };
            if (!sr.Name.Contains("Total")) return sr;
            sr.Color = Color.White;
            sr.BorderWidth = 2;
            return sr;
        }

        #endregion

        #region Moving

        /// <summary>
        /// Update with percent
        /// </summary>
        private void Update1()
        {
            if (_value > 100) _value = 100;
            Chart.Series[_index].LegendText = _value > 0 ? $@"{_name} : {_value:00.00} %" : $@"{_name} : --------";
            Chart.Series[_index].Points.AddY(_value);
        }

        /// <summary>
        /// Update with non percent
        /// </summary>
        private void Update2()
        {
            _value /= 131072;
            if (_value > Chart.ChartAreas[0].Axes[1].Maximum) Chart.ChartAreas[0].Axes[1].Maximum = _value;
            Chart.Series[_index].LegendText = _value > 0 ? $@"{_name} : {_value:00.00} Mbps" : $@"{_name} : --------";
            Chart.Series[_index].Points.AddY(_value);
        }

        /// <summary>
        /// Field assignment
        /// </summary>
        /// <param name="value"> A float value </param>
        /// <param name="index"> Series index </param>
        /// <param name="name"> Series name </param>
        public void AddPoint(float value, int index, string name)
        {
            _value = value;
            _index = index;
            _name = name;
            _action();
        }

        /// <summary>
        /// Chart slider
        /// </summary>
        public void Slide()
        {
            Chart.ChartAreas[0].Axes[0].Minimum += 0.033;
            Chart.ChartAreas[0].Axes[0].Maximum += 0.033;
        }

        #endregion

        #region Events

        /// <summary>
        /// Makes the legends visible
        /// </summary>
        /// <param name="sender"> Event object </param>
        /// <param name="e"> Event object </param>
        private void Chart_MouseEnter(object sender, EventArgs e)
        {
            Chart.Legends[0].Enabled = true;
            LblD.Visible = true;
            LblR.Visible = true;
        }

        /// <summary>
        /// Makes the legends invisible
        /// </summary>
        /// <param name="sender"> Event object </param>
        /// <param name="e"> Event object </param>
        private void Chart_MouseLeave(object sender, EventArgs e)
        {
            Chart.Legends[0].Enabled = false;
            LblD.Visible = false;
            LblR.Visible = false;
        }

        #endregion

        #endregion

        #region DevTests

        private bool _range;
        private new void DoubleClick(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) != 0)
            {
                Chart.ChartAreas[0].Area3DStyle.Enable3D = !Chart.ChartAreas[0].Area3DStyle.Enable3D;
                LblD.Text = Chart.ChartAreas[0].Area3DStyle.Enable3D ? @"Double Left Click to 2D" : @"Double Left Click to 3D";
            }

            if ((e.Button & MouseButtons.Right) != 0)
            {
                _range = !_range;
                LblR.Text = _range ? @"Double Right Click to Line" : @"Double Right Click to Range";
                SwitchSeries();
            }
        }

        Random _rnd = new Random();
        private void SwitchSeries()
        {
            for (int i = 0; i < Chart.Series.Count; i++)
            {
                Chart.Series[i] = _range ? GetSeriesRange(Chart.Series[i]) : GetSeriesLine(Chart.Series[i]);
            }
        }

        private Series GetSeriesRange(Series series)
        {
            if (series.Name.Contains("Total"))
            {
                series.ChartType = SeriesChartType.Line;
                series.Color = Color.White;
                series.BorderWidth = 2;
            }
            else
            {
                series.ChartType = SeriesChartType.Range;
                series.Color = Color.FromArgb(96, _rnd.Next(96, 255), _rnd.Next(96, 255), _rnd.Next(96, 255));
                series.BackSecondaryColor = Color.Transparent;
                series.BackGradientStyle = GradientStyle.TopBottom;
            }

            return series;
        }

        private Series GetSeriesLine(Series series)
        {
            series.ChartType = SeriesChartType.FastLine;
            series.Color = Color.FromArgb(_rnd.Next(96, 255), _rnd.Next(96, 255), _rnd.Next(96, 255));
            if (!series.Name.Contains("Total")) return series;
            series.Color = Color.White;
            series.BorderWidth = 2;
            return series;
        }


        #endregion
    }
}
