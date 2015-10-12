using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace CustomTimers
{
    public partial class CountdownUserControl : UserControl
    {
        //-----------------------------------------------
        // Private data members
        //-----------------------------------------------
        private CustomTimer _CountdownTimer = new CountdownTimer ();
        private bool _IsStopClicked = false;


        //-----------------------------------------------
        // Public properties
        //-----------------------------------------------
        public CustomTimer.TimerStates TimerState
        {
            get { return _CountdownTimer.State; }
        }

        public string Message
        {
            get { return txtMessage.Text; }
        }

        //-----------------------------------------------
        // Private member functions
        //-----------------------------------------------
        private void Init ()
        {
            _CountdownTimer.Elapsed += new
                EventHandler (_CustomTimer_Elapsed);
            _CountdownTimer.Completed += new
                EventHandler (_CustomTimer_Completed);
            _CountdownTimer.StateChanged += new
                EventHandler (_CountdownTimer_StateChanged);

            _CountdownTimer.SynchronizingObject = this;
        }

        private void UpdateLabels ()
        {
            lblHour.Visible = false;
            if (!_IsStopClicked)
            {
                lblHour.Text =
                    string.Format ("{0:00}", _CountdownTimer.Hour);
                lblMinute.Text =
                    string.Format ("{0:00}", _CountdownTimer.Minute);
                lblSecond.Text =
                    string.Format ("{0:00}", _CountdownTimer.Second);
                lblMillisecond.Text =
                    string.Format ("{0:000}", _CountdownTimer.Millisecond);
            }
        }

        private void UpdateInputs ()
        {
            cbxIntervalUnit.DataSource = System.Enum.GetValues (
                typeof (CustomTimer.IntervalUnits));
            txtInterval.Text = string.Format ("{0}", _CountdownTimer.Interval);
            txtHour.Text = string.Format ("{0:00}", _CountdownTimer.Hour);
            txtMinute.Text = string.Format ("{0:00}", _CountdownTimer.Minute);
            txtSecond.Text = string.Format ("{0:00}", _CountdownTimer.Second);
            txtMillisecond.Text = string.Format (
                "{0:000}", _CountdownTimer.Millisecond);
            cbxHighResolution.Checked = _CountdownTimer.UseHighResolution;
        }

        private void UpdateButtons ()
        {
            btnStart.Enabled = true;
            btnStop.Enabled = true;
            btnPause.Enabled = true;
            btnReset.Enabled = true;
            switch (_CountdownTimer.State)
            {
                case CustomTimer.TimerStates.Stopped:
                    btnPause.Enabled = false;
                    break;
                case CustomTimer.TimerStates.Paused:
                    btnPause.Enabled = false;
                    btnReset.Enabled = false;
                    break;
                case CustomTimer.TimerStates.Running:
                    btnStart.Enabled = false;
                    btnReset.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void Reset ()
        {
            _CountdownTimer.Reset ();
            UpdateLabels ();
            UpdateInputs ();
            UpdateButtons ();
        }

        //-----------------------------------------------
        // Public member functions
        //-----------------------------------------------
        public CountdownUserControl ()
        {
            InitializeComponent ();
            Init ();
            Reset ();
        }

        //-----------------------------------------------
        // Generated Events
        //-----------------------------------------------
        public event EventHandler TimerCompleted;
        protected virtual void OnTimerCompleted (EventArgs e)
        {
            TimerCompleted (this, e);
        }

        public event EventHandler TimerStarted;
        protected virtual void OnTimerStarted (EventArgs e)
        {
            TimerStarted (this, e);
        }

        //-----------------------------------------------
        // Event Handlers
        //-----------------------------------------------
        private void _CustomTimer_Elapsed (object sender, EventArgs e)
        {
            UpdateLabels ();
        }

        private void _CustomTimer_Completed (object sender, EventArgs e)
        {
            OnTimerCompleted (e);
        }

        private void _CountdownTimer_StateChanged (object sender, EventArgs e)
        {
            UpdateButtons ();
        }


        private void btnStart_Click (object sender, EventArgs e)
        {
            try
            {
                if (_CountdownTimer.State != CustomTimer.TimerStates.Paused)
                {
                    _CountdownTimer.Hour = Convert.ToInt32 (txtHour.Text);
                    _CountdownTimer.Minute = Convert.ToInt32 (txtMinute.Text);
                    _CountdownTimer.Second = Convert.ToInt32 (txtSecond.Text);
                    _CountdownTimer.Millisecond =
                        Convert.ToInt32 (txtMillisecond.Text);
                    _CountdownTimer.Interval =
                        Convert.ToInt32 (txtInterval.Text);
                    _CountdownTimer.IntervalUnit =
                        (CustomTimer.IntervalUnits) Enum.Parse (
                        typeof (CustomTimer.IntervalUnits),
                        cbxIntervalUnit.Text);

                    _CountdownTimer.FindEffectivTime ();

                    UpdateLabels ();
                }

                _IsStopClicked = false;
                _CountdownTimer.Start ();
                OnTimerStarted (new EventArgs ());
            }
            catch (Exception ex)
            {
                MessageBox.Show (string.Format ("{0}", ex.Message));
            }
            tableLayoutPanel12.Visible = false;
            tableLayoutPanel13.Visible = false;
            tableLayoutPanel14.Visible = false;
            tableLayoutPanel15.Visible = false;
        }

        private void btnPause_Click (object sender, EventArgs e)
        {
            _CountdownTimer.Pause ();
        }

        private void btnStop_Click (object sender, EventArgs e)
        {
            _IsStopClicked = true;
            _CountdownTimer.Stop ();

            tableLayoutPanel12.Visible = true;
            tableLayoutPanel13.Visible = true;
            tableLayoutPanel14.Visible = true;
            tableLayoutPanel15.Visible = true;
        }

        private void btnReset_Click (object sender, EventArgs e)
        {
            _IsStopClicked = false;
            Reset ();
        }

        private void cbxHighResolution_CheckedChanged (object sender, EventArgs e)
        {
            _CountdownTimer.UseHighResolution = cbxHighResolution.Checked;
        }
    }
}
