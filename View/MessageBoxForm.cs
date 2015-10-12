using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CustomTimers
{
    public partial class MessageBoxForm : Form
    {
        public MessageBoxForm ()
        {
            InitializeComponent ();
        }

        public string Message
        {
            get { return lblMessage.Text; }
            set { lblMessage.Text = value; }
        }

        private void btnOk_Click (object sender, EventArgs e)
        {
            this.Close ();
        }
    }
}