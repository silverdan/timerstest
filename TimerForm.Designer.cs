namespace CustomTimers
{
    partial class TimerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimerForm));
            this.nicoMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabTimer = new System.Windows.Forms.TabControl();
            this.tabpCountdown = new System.Windows.Forms.TabPage();
            this.tabpStopWatch = new System.Windows.Forms.TabPage();
            this.cbxIsTopMost = new System.Windows.Forms.CheckBox();
            this.ucCountdown = new CustomTimers.CountdownUserControl();
            this.ucStopWatch = new CustomTimers.StopWatchUserControl();
            this.menuStrip1.SuspendLayout();
            this.tabTimer.SuspendLayout();
            this.tabpCountdown.SuspendLayout();
            this.tabpStopWatch.SuspendLayout();
            this.SuspendLayout();
            // 
            // nicoMain
            // 
            this.nicoMain.Icon = ((System.Drawing.Icon)(resources.GetObject("nicoMain.Icon")));
            this.nicoMain.Text = "notifyIcon1";
            this.nicoMain.Visible = true;
            this.nicoMain.DoubleClick += new System.EventHandler(this.nicoMain_DoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(630, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabTimer
            // 
            this.tabTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabTimer.Controls.Add(this.tabpCountdown);
            this.tabTimer.Controls.Add(this.tabpStopWatch);
            this.tabTimer.Location = new System.Drawing.Point(0, 25);
            this.tabTimer.Name = "tabTimer";
            this.tabTimer.SelectedIndex = 0;
            this.tabTimer.Size = new System.Drawing.Size(630, 349);
            this.tabTimer.TabIndex = 2;
            // 
            // tabpCountdown
            // 
            this.tabpCountdown.Controls.Add(this.ucCountdown);
            this.tabpCountdown.Location = new System.Drawing.Point(4, 22);
            this.tabpCountdown.Name = "tabpCountdown";
            this.tabpCountdown.Padding = new System.Windows.Forms.Padding(3);
            this.tabpCountdown.Size = new System.Drawing.Size(622, 323);
            this.tabpCountdown.TabIndex = 0;
            this.tabpCountdown.Text = "倒计时";
            this.tabpCountdown.UseVisualStyleBackColor = true;
            // 
            // tabpStopWatch
            // 
            this.tabpStopWatch.Controls.Add(this.ucStopWatch);
            this.tabpStopWatch.Location = new System.Drawing.Point(4, 22);
            this.tabpStopWatch.Name = "tabpStopWatch";
            this.tabpStopWatch.Padding = new System.Windows.Forms.Padding(3);
            this.tabpStopWatch.Size = new System.Drawing.Size(622, 323);
            this.tabpStopWatch.TabIndex = 1;
            this.tabpStopWatch.Text = "秒表";
            this.tabpStopWatch.UseVisualStyleBackColor = true;
            // 
            // cbxIsTopMost
            // 
            this.cbxIsTopMost.AutoSize = true;
            this.cbxIsTopMost.Location = new System.Drawing.Point(426, 4);
            this.cbxIsTopMost.Name = "cbxIsTopMost";
            this.cbxIsTopMost.Size = new System.Drawing.Size(72, 16);
            this.cbxIsTopMost.TabIndex = 0;
            this.cbxIsTopMost.Text = "居于顶层";
            this.cbxIsTopMost.UseVisualStyleBackColor = false;
            this.cbxIsTopMost.CheckedChanged += new System.EventHandler(this.cbxIsTopMost_CheckedChanged);
            // 
            // ucCountdown
            // 
            this.ucCountdown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucCountdown.Location = new System.Drawing.Point(3, 3);
            this.ucCountdown.Name = "ucCountdown";
            this.ucCountdown.Size = new System.Drawing.Size(616, 317);
            this.ucCountdown.TabIndex = 0;
            // 
            // ucStopWatch
            // 
            this.ucStopWatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucStopWatch.Location = new System.Drawing.Point(3, 3);
            this.ucStopWatch.Name = "ucStopWatch";
            this.ucStopWatch.Size = new System.Drawing.Size(616, 317);
            this.ucStopWatch.TabIndex = 0;
            // 
            // TimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 374);
            this.Controls.Add(this.tabTimer);
            this.Controls.Add(this.cbxIsTopMost);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TimerForm";
            this.Text = "计时器 by 夏瑞丹";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TimerForm_FormClosed);
            this.Resize += new System.EventHandler(this.TimerForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabTimer.ResumeLayout(false);
            this.tabpCountdown.ResumeLayout(false);
            this.tabpStopWatch.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon nicoMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabTimer;
        private System.Windows.Forms.TabPage tabpStopWatch;
        private System.Windows.Forms.TabPage tabpCountdown;
        private CountdownUserControl ucCountdown;
        private StopWatchUserControl ucStopWatch;
        private System.Windows.Forms.CheckBox cbxIsTopMost;
    }
}

