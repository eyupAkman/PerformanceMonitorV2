using System;
using System.Windows.Forms;
using PerformanceMonitorV2.Management.Abstract;

namespace PerformanceMonitorV2.Management.Concrete
{
    public class FormManager : IFormManager
    {
        #region Fields

        // Method handler container
        private Action _adapter;

        // Timer for animation
        private readonly Timer _timer = new Timer();

        #endregion

        #region Constructor

        public FormManager()
        {
            _timer.Tick += (s, e) => { _adapter(); };
            _timer.Interval = 16;
        }

        #endregion

        #region Methods

        public void GetNewForm(Form form)
        {
            form.Opacity = 0;
            form.Show();
            _timer.Interval = 16;
            _adapter = () =>
            {
                if (form.Opacity < 1) form.Opacity += .0625;
                else _timer.Stop();
            };
            _timer.Start();
        }

        public void SwitchForm(Form currentForm, Form nextForm)
        {
            _timer.Interval = 16;
            _adapter = () =>
            {
                if (currentForm.Opacity > 0) currentForm.Opacity -= .0625;
                else
                {
                    _timer.Stop();
                    currentForm.Close();
                    GetNewForm(nextForm);
                }
            };
            _timer.Start();
        }

        public void Intro(Form introForm, Form nextForm)
        {
            introForm.Opacity = 0;
            introForm.Show();
            _timer.Interval = 16;
            _adapter = () =>
            {
                if (introForm.Opacity < 1) introForm.Opacity += .0625;
                else
                {
                    _timer.Interval = 500;
                    _adapter = () =>
                    {
                        _timer.Stop();
                        SwitchForm(introForm, nextForm);
                    };
                }
            };
            _timer.Start();
        }

        public void Exit(Form form)
        {
            _timer.Interval = 16;
            _adapter = () =>
            {
                if (form.Opacity > 0) form.Opacity -= .0625;
                else
                {
                    _timer.Dispose();
                    Application.Exit();
                }
            };
            _timer.Start();
        }

        #endregion
    }
}