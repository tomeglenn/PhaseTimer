namespace PhaseTimer
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            PhaseTimer.Properties.Settings settings1 = new PhaseTimer.Properties.Settings();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.lstTimers = new System.Windows.Forms.ListBox();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpAdd = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.intHours = new System.Windows.Forms.NumericUpDown();
            this.intSeconds = new System.Windows.Forms.NumericUpDown();
            this.lblHours = new System.Windows.Forms.Label();
            this.intMinutes = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.chkRepeat = new System.Windows.Forms.CheckBox();
            this.btnPause = new System.Windows.Forms.Button();
            this.lblCurrentTimeName = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.grpAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // lstTimers
            // 
            this.lstTimers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstTimers.FormattingEnabled = true;
            this.lstTimers.Location = new System.Drawing.Point(12, 88);
            this.lstTimers.Name = "lstTimers";
            this.lstTimers.Size = new System.Drawing.Size(421, 69);
            this.lstTimers.TabIndex = 0;
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentTime.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTime.Location = new System.Drawing.Point(12, 46);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(421, 37);
            this.lblCurrentTime.TabIndex = 1;
            this.lblCurrentTime.Text = "0:00:00";
            this.lblCurrentTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(376, 161);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(57, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grpAdd
            // 
            this.grpAdd.Controls.Add(this.label3);
            this.grpAdd.Controls.Add(this.lblSeconds);
            this.grpAdd.Controls.Add(this.btnAdd);
            this.grpAdd.Controls.Add(this.txtTitle);
            this.grpAdd.Controls.Add(this.intHours);
            this.grpAdd.Controls.Add(this.intSeconds);
            this.grpAdd.Controls.Add(this.lblHours);
            this.grpAdd.Controls.Add(this.intMinutes);
            this.grpAdd.Location = new System.Drawing.Point(12, 196);
            this.grpAdd.Name = "grpAdd";
            this.grpAdd.Size = new System.Drawing.Size(421, 62);
            this.grpAdd.TabIndex = 16;
            this.grpAdd.TabStop = false;
            this.grpAdd.Text = "Add Phase";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "mins";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Location = new System.Drawing.Point(317, 31);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(29, 13);
            this.lblSeconds.TabIndex = 10;
            this.lblSeconds.Text = "secs";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(351, 26);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(57, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(11, 28);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(97, 20);
            this.txtTitle.TabIndex = 3;
            // 
            // intHours
            // 
            this.intHours.Location = new System.Drawing.Point(114, 28);
            this.intHours.Name = "intHours";
            this.intHours.Size = new System.Drawing.Size(42, 20);
            this.intHours.TabIndex = 9;
            // 
            // intSeconds
            // 
            this.intSeconds.Location = new System.Drawing.Point(269, 28);
            this.intSeconds.Name = "intSeconds";
            this.intSeconds.Size = new System.Drawing.Size(42, 20);
            this.intSeconds.TabIndex = 11;
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(162, 31);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(21, 13);
            this.lblHours.TabIndex = 8;
            this.lblHours.Text = "hrs";
            // 
            // intMinutes
            // 
            this.intMinutes.Location = new System.Drawing.Point(188, 28);
            this.intMinutes.Name = "intMinutes";
            this.intMinutes.Size = new System.Drawing.Size(42, 20);
            this.intMinutes.TabIndex = 4;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(363, 264);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(70, 53);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(211, 264);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(70, 53);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop/Reset";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // chkRepeat
            // 
            this.chkRepeat.AutoSize = true;
            this.chkRepeat.Checked = true;
            this.chkRepeat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRepeat.Location = new System.Drawing.Point(102, 283);
            this.chkRepeat.Name = "chkRepeat";
            this.chkRepeat.Size = new System.Drawing.Size(103, 17);
            this.chkRepeat.TabIndex = 13;
            this.chkRepeat.Text = "Repeat on finish";
            this.chkRepeat.UseVisualStyleBackColor = true;
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(287, 264);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(70, 53);
            this.btnPause.TabIndex = 14;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // lblCurrentTimeName
            // 
            this.lblCurrentTimeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentTimeName.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentTimeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTimeName.ForeColor = System.Drawing.Color.Gray;
            this.lblCurrentTimeName.Location = new System.Drawing.Point(12, 9);
            this.lblCurrentTimeName.Name = "lblCurrentTimeName";
            this.lblCurrentTimeName.Size = new System.Drawing.Size(421, 37);
            this.lblCurrentTimeName.TabIndex = 17;
            this.lblCurrentTimeName.Text = "Name";
            this.lblCurrentTimeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipText = "Timer has been minimized to the tray";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "PhaseTimer v1.0";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(445, 325);
            this.Controls.Add(this.lblCurrentTime);
            this.Controls.Add(this.lblCurrentTimeName);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lstTimers);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.grpAdd);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.chkRepeat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "Phase Timer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.grpAdd.ResumeLayout(false);
            this.grpAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intMinutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstTimers;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox grpAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.NumericUpDown intHours;
        private System.Windows.Forms.NumericUpDown intSeconds;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.NumericUpDown intMinutes;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.CheckBox chkRepeat;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Label lblCurrentTimeName;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

