using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace PhaseTimer
{
    public partial class FrmMain : Form
    {
        private ApplicationConfiguration config;
        private int currentPhaseIndex;
        private readonly Timer timer;
        private bool waitOneTick;
        private bool paused;

        private readonly string configPath = Application.UserAppDataPath + "\\config.json";

        public FrmMain()
        {
            InitializeComponent();

            config = new ApplicationConfiguration();

            LoadSettings();

            timer = new Timer {Interval = 1000};
            timer.Tick += Timer_Tick;

            ResetTimer();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (waitOneTick)
            {
                RefreshTimeLabel();
                waitOneTick = false;
                return;
            }

            var currentPhase = config.Phases[currentPhaseIndex];

            currentPhase.TimeRemaining = currentPhase.TimeRemaining.Add(new TimeSpan(0, 0, 0, -1));
            RefreshTimeLabel();

            if (currentPhase.TimeRemaining.TotalSeconds <= 0)
            {
                Alert();

                currentPhase.Reset();
                if (config.Phases.Count > currentPhaseIndex + 1)
                {
                    currentPhaseIndex++;
                    waitOneTick = true;
                    return;
                }

                if (chkRepeat.Checked)
                {
                    currentPhaseIndex = 0;
                    waitOneTick = true;
                    return;
                }

                StopTimer();
            }
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            var hours = int.Parse(intHours.Text);
            var minutes = int.Parse(intMinutes.Text);
            var seconds = int.Parse(intSeconds.Text);

            if (hours == 0 && minutes == 0 && seconds == 0)
            {
                MessageBox.Show(this, "You cannot add a 0 seconds phase", "Unable to add phase", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var timePeriod = new Phase(txtTitle.Text, new TimeSpan(hours, minutes, seconds));
            config.Phases.Add(timePeriod);

            txtTitle.Text = "";
            intHours.Text = "0";
            intMinutes.Text = "0";
            intSeconds.Text = "0";

            RefreshListView();
        }

        private void RefreshListView()
        {
            lstTimers.Items.Clear();

            for(int i = 0; i < config.Phases.Count; i++)
            {
                var timePeriod = config.Phases[i];
                var name = GetTimerNameFromIndex(i);
                lstTimers.Items.Add($"{name} - {timePeriod.Time}");
            }
        }

        private void RefreshTimeLabel()
        {
            if (!config.Phases.Any())
            {
                lblCurrentTime.Text = "No Current Timer";
                Text = $"{lblCurrentTime.Text}";
                return;
            }

            var timePeriod = config.Phases[currentPhaseIndex];
            var pausedText = paused ? " (Paused)" : "";
            lblCurrentTimeName.Text = GetTimerNameFromIndex(currentPhaseIndex);
            lblCurrentTime.Text = $"{timePeriod.TimeRemaining}{pausedText}";

            Text = $"{lblCurrentTimeName.Text} - {lblCurrentTime.Text}";
        }

        private void StartTimer()
        {
            if (!config.Phases.Any())
            {
                MessageBox.Show(this, "You must add at least one timer to start", "No Timers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                StopTimer();
                return;
            }

            paused = false;
            timer.Start();
            RefreshTimeLabel();
        }

        private void StopTimer()
        {
            if (config.Phases.Any())
            {
                timer.Stop();
                ResetTimer();
            }
        }

        private void ResetTimer()
        {
            currentPhaseIndex = 0;
            paused = false;

            if (config.Phases.Any())
            {
                config.Phases[currentPhaseIndex].Reset();
            }

            RefreshTimeLabel();
        }

        private void Alert()
        {
            notifyIcon.ShowBalloonTip(0, "", $"{GetTimerNameFromIndex(currentPhaseIndex)} finished", ToolTipIcon.Info);
        }

        private string GetTimerNameFromIndex(int index)
        {
            if (!config.Phases.Any())
            {
                return "";
            }

            var timePeriod = config.Phases[index];
            return string.IsNullOrEmpty(timePeriod.Name) ? $"Timer {currentPhaseIndex + 1}" : timePeriod.Name;
        }

        private void LoadSettings()
        {
            if (File.Exists(configPath))
            {
                try
                {
                    var json = File.ReadAllText(configPath);
                    config = JsonConvert.DeserializeObject<ApplicationConfiguration>(json);

                    chkRepeat.Checked = config.RepeatOnFinish;
                }
                catch (Exception)
                {
                    SaveSettings();
                }
            }
            else
            {
                SaveSettings();
            }

            RefreshListView();
        }

        private void SaveSettings()
        {
            config.RepeatOnFinish = chkRepeat.Checked;

            var json = JsonConvert.SerializeObject(config);
            File.WriteAllText(configPath, json);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartTimer();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopTimer();
        }
        
        private void btnPause_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            paused = true;
            RefreshTimeLabel();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                MessageBox.Show(this, "You cannot delete a timer while it is running, please stop the timer first.", "Unable to delete timer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (lstTimers.SelectedIndex < 0)
            {
                MessageBox.Show(this, "Please select a timer to delete", "No selected timer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            config.Phases.RemoveAt(lstTimers.SelectedIndex);
            ResetTimer();
            RefreshListView();
            RefreshTimeLabel();
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                notifyIcon.Visible = true;
                ShowInTaskbar = false;
            }
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
            notifyIcon.Visible = false;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }
    }
}
