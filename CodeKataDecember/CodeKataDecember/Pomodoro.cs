using System;
using System.Timers;

namespace CodeKataDecember
{
    public class Pomodoro
    {
        #region "[ Consts ]"
        private int TIME = 25;
        #endregion

        #region "[ Attributes ]"
        private Timer _timer;
        private int _minutes;
        private int _totals;
        private int _interruptions;
        public int Minutes
        {
            get { return _minutes; }
            set { _minutes = value; }
        }
        public int Interruptions
        {
            get { return _interruptions; }
            set { _interruptions = value; }
        }
        #endregion

        #region "[ Constructors ]"
        public Pomodoro()
        {
           SetUp(TIME);
        }
        public Pomodoro(int time)
        {
            SetUp(time);
        }
        #endregion

        #region "[ Public Methods ]"
        public void Start()
        {
            _timer.Start();
        }
        public void Reset()
        {
            _minutes = TIME;
            _interruptions = 0;
        }
        public void Stop()
        {
            if (0 == _minutes)
            {
                _totals++;
                _timer.Stop();
            }
            else
                throw new Exception("Pomodoro is not started");
        }
        public void Pause()
        {
            if (0 < _minutes)
            {
                _timer.Stop();
                _interruptions++;
            }
            else
                throw new Exception("Pomodoro is not started");
        }
        #endregion

        #region "[ Events ]"
        protected void UpdateMinutes(Object sender, EventArgs e)
        {
            _minutes--;
            if (0 == _minutes)
                _timer.Stop();
        }
        #endregion

        #region "[ Private Methods]"
        private void SetUp(int minutes)
        {
            _timer = new Timer();
            //each one seconds
            _timer.Interval = 1000;
            _minutes = minutes * 60;
            TIME = minutes;
            _totals = 0;
            _interruptions = 0;
        }
        #endregion
    }
}
