using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PerformanceMonitorV2.WindowsFormsUI.Concrete.UserControls.Base
{
    public partial class UcHud : UserControl
    {
        #region Fields

        // Player handler container
        private Action _action;

        // Temporary value container
        private float _value;

        // Player switcher container
        private bool _isPercentage;

        #endregion

        #region Constructor

        public UcHud()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Top label property
        /// </summary>
        [DisplayName("Text Top"), Category("Special")]
        public string TopLabel
        {
            get => LabelTop.Text;
            set => LabelTop.Text = value;
        }

        /// <summary>
        /// Bottom label property
        /// </summary>
        [DisplayName("Text Bottom"), Category("Special")]
        public string BottomLabel
        {
            get => LabelBottom.Text;
            set => LabelBottom.Text = value;
        }

        /// <summary>
        /// Set value and update hud
        /// </summary>
        [DisplayName("Value"), Category("Special")]
        public float Value
        {
            get => _value;
            set
            {
                _value = value;
                _action();
            }
        }

        /// <summary>
        /// Player handler switcher
        /// </summary>
        [DisplayName("Is Percentage ?"), Category("Special")]
        public bool IsPercent
        {
            get => _isPercentage;
            set
            {
                _isPercentage = value;
                _action = _isPercentage ? (Action) Update1 : Update2;
            }
        }

        /// <summary>
        /// Hud back color switcher
        /// </summary>
        [DisplayName("Back Color"), Category("Special")]
        public Color BackColor2
        {
            get => Hud.BackColor;
            set
            {
                Hud.BackColor = value;
                Hud.InnerColor = value;
                LabelTop.BackColor = value;
                LabelBottom.BackColor = value;
            }
        }

        /// <summary>
        /// Hud fore color switcher
        /// </summary>
        [DisplayName("Fore Color"), Category("Special")]
        public Color ForeColor2
        {
            get => Hud.ForeColor;
            set
            {
                Hud.ForeColor = value;
                LabelTop.ForeColor = value;
                LabelBottom.ForeColor = value;
            }
        }

        /// <summary>
        /// Hud outer color switcher
        /// </summary>
        [DisplayName("Outer Color"), Category("Special")]
        public Color OuterColor
        {
            get => Hud.OuterColor;
            set => Hud.OuterColor = value;
        }

        /// <summary>
        /// Hud progress color switcher
        /// </summary>
        [DisplayName("Progress Color"), Category("Special")]
        public Color ProgressColor
        {
            get => Hud.ProgressColor;
            set => Hud.ProgressColor = value;
        }

        /// <summary>
        /// Hud maximum value controller
        /// </summary>
        [DisplayName("Maximum"), Category("Special")]
        public int Maximum
        {
            get => Hud.Maximum;
            set => Hud.Maximum = value;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Hud update with percent
        /// </summary>
        private void Update1()
        {
            if (_value > 100) _value = 100;
            Hud.Value = (byte) _value;
            Hud.Text = $@"{_value:0}%";
        }

        /// <summary>
        /// Hud update with non percent
        /// </summary>
        private void Update2()
        {
            _value /= 131072;
            if (_value > Hud.Maximum) Hud.Maximum = (short) _value;
            Hud.Value = (short) _value;
            Hud.Text = $@"{_value:0.##}";
        }

        #endregion
    }
}
