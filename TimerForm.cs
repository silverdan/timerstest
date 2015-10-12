/************************************************************************************

************************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CustomTimers
{
    public partial class TimerForm : Form
    {
       
        private MessageBoxForm _MessageBoxForm = new MessageBoxForm ();
        public TimerForm ()
        {
            InitializeComponent ();

            ucCountdown.TimerCompleted += new EventHandler(ucCountdown_TimerCompleted);
            ucCountdown.TimerStarted += new EventHandler(ucCountdown_TimerStarted);
        }
        private void TimerForm_Resize (object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                this.Hide ();
                nicoMain.Text = string.Format (
                    "{0}: {1}", ucCountdown.TimerState, ucCountdown.Message);
            }
        }

        private void nicoMain_DoubleClick (object sender, EventArgs e)
        {
            this.Show ();
            WindowState = FormWindowState.Normal;
        }

        private void aboutToolStripMenuItem_Click (object sender, EventArgs e)
        {
        
            _MessageBoxForm.Message = string.Format (
                "\n" +
                "Author: ÏÄÈðµ¤\n" +
               
                " \n");
            _MessageBoxForm.StartPosition = FormStartPosition.CenterParent;
            _MessageBoxForm.ShowDialog (this);

        }

        private void ucCountdown_TimerCompleted (object sender, EventArgs e)
        {
            this.Show ();
            this.WindowState = FormWindowState.Normal;
            this.TopMost = true;
            nicoMain.Text = string.Format (
                "{0}: {1}", ucCountdown.TimerState, ucCountdown.Message);

            _MessageBoxForm.Message = string.Format (
                "{0}", ucCountdown.Message);
            _MessageBoxForm.StartPosition = FormStartPosition.CenterParent;
            _MessageBoxForm.ShowDialog (this);
            this.TopMost = false;
        }

        private void ucCountdown_TimerStarted (object sender, EventArgs e)
        {
            nicoMain.Text = string.Format (
                "{0}: {1}", ucCountdown.TimerState, ucCountdown.Message);
        }
         private void cbxIsTopMost_CheckedChanged (object sender, EventArgs e)
        {
            this.TopMost = cbxIsTopMost.Checked;
        }

        private void TimerForm_FormClosed (object sender, FormClosedEventArgs e)
        {
            nicoMain.Dispose ();
        }

    }


}