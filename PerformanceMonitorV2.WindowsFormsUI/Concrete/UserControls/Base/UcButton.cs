using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using PerformanceMonitorV2.WindowsFormsUI.Abstract;

namespace PerformanceMonitorV2.WindowsFormsUI.Concrete.UserControls.Base
{
    public partial class UcButton : UserControl, IButton
    {
        #region Fields

        // Timer for resizing animation
        private readonly Timer _timer = new Timer {Interval = 15};

        // Alpha channel for background color
        private byte _alpha;

        // Button image container
        private Image _img;

        // Resizing range
        private byte _range;

        // Range counter
        private byte _counter;

        #endregion

        #region Constructor

        public UcButton()
        {
            InitializeComponent();
            SetRange();
            WireAllControls(this);
        }

        #endregion

        #region Properties

        // Button default image
        [Category("Images"), DisplayName("Image")]
        public Image Image
        {
            get => Box.Image;
            set
            {
                _img = value;
                Box.Image = _img;
            }
        }

        // Button Image on Active
        [Category("Images"), DisplayName("Image On Active")]
        public Image ImgAct { get; set; }

        #endregion

        #region Methods

        #region Setups

        /// <summary>
        /// Set resize range
        /// </summary>
        private void SetRange()
        {
            _range = (byte) (Width * .2);
        }

        /// <summary>
        /// Wire all controls
        /// </summary>
        /// <param name="cont"> A container type control </param>
        private void WireAllControls(Control cont)
        {
            foreach (Control ctl in cont.Controls)
            {
                ctl.Click += ctl_Click;
                if (ctl.HasChildren)
                {
                    WireAllControls(ctl);
                }
            }
        }

        /// <summary>
        /// Event invoker
        /// </summary>
        /// <param name="sender"> Event object </param>
        /// <param name="e"> Event object </param>
        private void ctl_Click(object sender, EventArgs e)
        {
            InvokeOnClick(this, EventArgs.Empty);
        }

        /// <summary>
        /// Set size and range
        /// </summary>
        /// <param name="sender"> Event object </param>
        /// <param name="e"> Event object </param>
        private void UcButton_SizeChanged(object sender, EventArgs e)
        {
            Box.Size = Size;
            SetRange();
        }

        #endregion

        #region Events

        /// <summary>
        /// Zoom in event starter
        /// </summary>
        /// <param name="sender"> Event object </param>
        /// <param name="e"> Event object </param>
        private void UcButton_MouseEnter(object sender, EventArgs e)
        {
            Box.Image = ImgAct;
            _timer.Tick -= ZoomOut;
            _timer.Tick += ZoomIn;
            _timer.Start();
        }

        /// <summary>
        /// Zoom out event starter
        /// </summary>
        /// <param name="sender"> Event object </param>
        /// <param name="e"> Event object </param>
        private void UcButton_MouseLeave(object sender, EventArgs e)
        {
            _timer.Tick -= ZoomIn;
            _timer.Tick += ZoomOut;
            _timer.Start();
        }

        #endregion

        #region Resizing Events

        /// <summary>
        /// Zoom in event
        /// </summary>
        /// <param name="sender"> Event object </param>
        /// <param name="e"> Event object </param>
        private void ZoomIn(object sender, EventArgs e) // Zoom in to icon
        {
            if (_counter < _range)
            {
                Box.Width += 2;
                Box.Height += 2;
                Box.Left--;
                Box.Top--;
                _counter += 2;
                _alpha += 3;
                Box.BackColor = Color.FromArgb(_alpha, 255, 255, 255);
            }
            else
            {
                _timer.Stop();
            }
        }

        /// <summary>
        /// Zoom out event
        /// </summary>
        /// <param name="sender"> Event object </param>
        /// <param name="e"> Event object </param>
        private void ZoomOut(object sender, EventArgs e) // Zoom out from icon
        {
            if (_counter > 0)
            {
                Box.Width -= 2;
                Box.Height -= 2;
                Box.Left++;
                Box.Top++;
                _counter -= 2;
                _alpha -= 3;
                Box.BackColor = Color.FromArgb(_alpha, 255, 255, 255);
            }
            else
            {
                _timer.Stop();
                _alpha = 0;
                Box.Image = _img;
            }
        }

        #endregion

        #endregion
    }
}
