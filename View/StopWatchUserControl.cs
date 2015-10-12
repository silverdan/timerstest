using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace CustomTimers
{
    public partial class StopWatchUserControl : UserControl
    {
        //-----------------------------------------------
        // Private data members
        //-----------------------------------------------
        private StopWatchTimer _StopWatch = new StopWatchTimer ();
        private bool _IsStopClicked = false;

        //-----------------------------------------------
        // Public properties
        //-----------------------------------------------

        //-----------------------------------------------
        // Private member functions
        //-----------------------------------------------
        private void Init ()
        {
            _StopWatch.SynchronizingObject = this;
            _StopWatch.Elapsed += new
                EventHandler (_StopWatch_Elapsed);

            _StopWatch.StateChanged += new
                EventHandler (_StopWatch_StateChanged);

        }

        private void Reset ()
        {
            _StopWatch.Reset ();
            UpdateLabels ();
            UpdateInputs ();
            UpdateButtons ();
        }

        private void UpdateLabels ()
        {
            if (!_IsStopClicked)
            {
                lblHour.Text =
                    string.Format ("{0:00}", _StopWatch.Hour);
                lblMinute.Text =
                    string.Format ("{0:00}", _StopWatch.Minute);
                lblSecond.Text =
                    string.Format ("{0:00}", _StopWatch.Second);
                lblMillisecond.Text =
                    string.Format ("{0:000}", _StopWatch.Millisecond);
            }
        }

        private void UpdateInputs ()
        {
            cbxIntervalUnit.DataSource = System.Enum.GetValues (
                typeof (CustomTimer.IntervalUnits));
            txtInterval.Text = string.Format ("{0}", _StopWatch.Interval);
            cbxHighResolution.Checked = _StopWatch.UseHighResolution;
        }

        private void UpdateButtons ()
        {
            btnStart.Enabled = true;
            btnStop.Enabled = true;
            btnPause.Enabled = true;
            btnReset.Enabled = true;
            switch (_StopWatch.State)
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

        //-----------------------------------------------
        // Protected member function
        //-----------------------------------------------

        //-----------------------------------------------
        // Public member functions
        //-----------------------------------------------
        public StopWatchUserControl ()
        {
            InitializeComponent ();
            Init ();
            Reset ();
        }

        //-----------------------------------------------
        // Generated Events
        //-----------------------------------------------

        //-----------------------------------------------
        // Event Handlers
        //-----------------------------------------------       
        private void _StopWatch_Elapsed (
            object sender, EventArgs e)
        {
            UpdateLabels ();
        }

        private void _StopWatch_StateChanged (object sender, EventArgs e)
        {
            UpdateButtons ();
        }

        private void btnStart_Click (object sender, EventArgs e)
        {
            try
            {
                if (_StopWatch.State != CustomTimer.TimerStates.Paused)
                {
                    _StopWatch.Interval =
                            Convert.ToInt32 (txtInterval.Text);
                    _StopWatch.IntervalUnit =
                        (CustomTimer.IntervalUnits) Enum.Parse (
                        typeof (CustomTimer.IntervalUnits),
                        cbxIntervalUnit.Text);

                    UpdateLabels ();
                }

                _IsStopClicked = false;
                _StopWatch.Start ();
            }
            catch (Exception ex)
            {
                MessageBox.Show (string.Format ("{0}", ex.Message));
            }
        }

        private void btnPause_Click (object sender, EventArgs e)
        {
            _StopWatch.Pause ();
        }
                
        private void btnStop_Click (object sender, EventArgs e)
        {
            _IsStopClicked = true;
            _StopWatch.Stop ();
        }

        private void btnReset_Click (object sender, EventArgs e)
        {
            _IsStopClicked = false;
            Reset ();
        }

        private void cbxHighResolution_CheckedChanged (object sender, EventArgs e)
        {
            _StopWatch.UseHighResolution = cbxHighResolution.Checked;
        }
        
    }
}
