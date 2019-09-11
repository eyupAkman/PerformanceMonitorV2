using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using PerformanceMonitorV2.WindowsFormsUI.Concrete.UserControls.Base;

namespace PerformanceMonitorV2.WindowsFormsUI.Concrete.PlayerF
{
    public class Player
    {
        #region Fields

        #region Object instances

        // Timer for update period
        private static readonly Timer Timer = new Timer { Interval = 33 };

        // Hud instance container
        private static UcHud _hud;

        // Chart instance container
        private static UcChart _chart;

        // Performance counter list instance container
        private static List<PerformanceCounter> _peCounters;

        // Name list instance container
        private static List<string> _names;

        #endregion

        #region Reminders and temporary value

        // Active page counter container
        private static readonly byte[] Counters = new byte[4];

        // Active page number
        private static byte _index;

        // Player status container
        private static bool _playing;

        // Temporary value container
        private static float _temp;

        #endregion

        #endregion

        #region Methods

        #region Setups

        /// <summary>
        /// Player setup
        /// </summary>
        /// <param name="hud"> A UcHud </param>
        /// <param name="chart"> A UcChart </param>
        /// <param name="counters"> A Performance counter list </param>
        /// <param name="names"> A name list </param>
        /// <param name="name"> A counter name </param>
        public static void SetPlayer(UcHud hud, UcChart chart, List<PerformanceCounter> counters, List<string> names,
            string name)
        {
            _hud = hud;
            _chart = chart;
            _peCounters = counters;
            _names = names;
            _index = SetIndex(name);
        }

        /// <summary>
        /// Set counter index
        /// </summary>
        /// <param name="name"> "cpu" or "ram" or "disk" or "net" </param>
        /// <returns></returns>
        private static byte SetIndex(string name)
        {
            switch (name)
            {
                case "cpu": return 0;
                case "ram": return 1;
                case "disk": return 2;
                case "net": return 3;
                default: return 0;
            }
        }

        #endregion

        #region Playing Options

        /// <summary>
        /// Player start
        /// </summary>
        public static void Start()
        {
            if (_playing) return;
            Timer.Tick += Play;
            Timer.Start();
            _playing = true;
        }

        /// <summary>
        /// Player stop
        /// </summary>
        public static void Stop()
        {
            if (!_playing) return;
            Timer.Tick -= Play;
            Timer.Stop();
            _playing = false;
        }

        /// <summary>
        /// Playing charts and hud
        /// </summary>
        /// <param name="sender"> Event object </param>
        /// <param name="e"> Event object </param>
        private static void Play(object sender, EventArgs e)
        {
            _chart.Slide();
            Counters[_index]++;
            if (Counters[_index] < 30) return;
            _temp = _peCounters[0].NextValue();
            _hud.Value = _temp;
            _chart.AddPoint(_temp, 0, _names[0]);
            for (int i = 1; i < _names.Count; i++)
            {
                _chart.AddPoint(_peCounters[i].NextValue(), i, _names[i]);
            }

            Counters[_index] = 0;
        }

        

        #endregion

        #endregion
    }
}