using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.Media;
using System.IO;

namespace AlarmApp
{
    public partial class AlarmApp : Form
    {
        // Global variables

        public static bool flag = false;
        int hour = 0;
        int minute = 0;
        int second = 0;
        int ms = 0;

        public AlarmApp()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            string currentDate = DateTime.Now.ToLongDateString();
            labelCurrentDateValue.Text = currentDate;
            timerCurrentTime.Start();
            panel1.BackColor = System.Drawing.Color.Red;

        }

        private void timerCurrentTime_Tick(object sender, EventArgs e)
        {

            string currentTime = DateTime.Now.ToLongTimeString();
            labelCurrentTimeValue.Text = currentTime;
        }

        private void buttonAddAlarm_Click(object sender, EventArgs e)
        {
            if (comboBoxHour.SelectedItem == null || comboBoxMinutes.SelectedItem == null || comboBoxSecond.SelectedItem == null || comboBoxPeriod.SelectedItem == null)
            {
                flag = false;
                System.Windows.Forms.MessageBox.Show("Not valid time!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                if (timerAlarm.Enabled == true)
                {
                    System.Windows.Forms.MessageBox.Show("You can set one alarm at the same time. If you want to set new alarm, remove exist one then add new one!", "Alarm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else if (timerAlarm.Enabled == false)
                {
                    comboBoxHour.Enabled = false;
                    comboBoxMinutes.Enabled = false;
                    comboBoxPeriod.Enabled = false;
                    comboBoxSecond.Enabled = false;
                    flag = true;
                    timerAlarm.Start();
                    labelIsAlarmSet.Text = "set!";
                    labelIsAlarmSet.ForeColor = System.Drawing.Color.Green;
                    labelAlarmStatus.ForeColor = System.Drawing.Color.Green;
                    System.Windows.Forms.MessageBox.Show("Alarm is added! \n\nAlarm title: " + (textBoxTitle.Text != "" ? textBoxTitle.Text : "No added alarm title."), "Alarm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void timerAlarm_Tick(object sender, EventArgs e)
        {
            if (flag)
            {
                string alarmTime = comboBoxHour.SelectedItem + ":" + comboBoxMinutes.SelectedItem + ":" + comboBoxSecond.SelectedItem + " " + comboBoxPeriod.SelectedItem;
                TimeSpan remainingTime = DateTime.Parse(alarmTime) - DateTime.Parse(labelCurrentTimeValue.Text);
                if (remainingTime.TotalSeconds == 0)
                {
                    axWindowsMediaPlayerAlarm.Ctlcontrols.stop();
                    labelRemainingTimeValue.Text = "00:00:00";
                    axWindowsMediaPlayerAlarm.Ctlcontrols.play();
                }
                else if (remainingTime.TotalHours < 0)
                {
                    labelRemainingTimeValue.Text = "So much time left.";
                }
                if (remainingTime.TotalSeconds > 0) labelRemainingTimeValue.Text = remainingTime.ToString();
                if (remainingTime.TotalSeconds <= 10 && remainingTime.TotalSeconds > 0 )
                {
                    axWindowsMediaPlayerTiktak.URL = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Voices/TicTak.mp3");
                    axWindowsMediaPlayerTiktak.Ctlcontrols.play();
                }
                if (labelCurrentTimeValue.Text.ToString().Equals(alarmTime.ToString()))
                {
                    axWindowsMediaPlayerTiktak.Ctlcontrols.stop();
                    labelRemainingTimeValue.Text = "00:00:00";
                    axWindowsMediaPlayerAlarm.URL = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Voices/Alarm.mp3");
                    axWindowsMediaPlayerAlarm.Ctlcontrols.play();
                    DialogResult result = System.Windows.Forms.MessageBox.Show("Time is up!\nIf you click 'No', The alarm time will be delayed(1 min.)!", textBoxTitle.Text != "" ? textBoxTitle.Text : "Alarm", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    axWindowsMediaPlayerAlarm.Ctlcontrols.stop();
                    if (result == DialogResult.Yes)
                    {
                        comboBoxHour.Enabled = true;
                        comboBoxMinutes.Enabled = true;
                        comboBoxPeriod.Enabled = true;
                        comboBoxSecond.Enabled = true;
                        timerAlarm.Stop();
                        labelIsAlarmSet.Text = "not set!";
                        labelRemainingTimeValue.Text = "00:00:00";
                        labelIsAlarmSet.ForeColor = System.Drawing.Color.Red;
                        labelAlarmStatus.ForeColor = System.Drawing.Color.Red;
                        axWindowsMediaPlayerAlarm.Ctlcontrols.stop();
                    }
                    else if (result == DialogResult.No) {
                        ++comboBoxMinutes.SelectedIndex;
                        axWindowsMediaPlayerAlarm.Ctlcontrols.stop();
                    }
                }
            }
        }

        private void buttonRemoveAlarm_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayerAlarm.Ctlcontrols.stop();
            if (comboBoxHour.SelectedItem == null || comboBoxMinutes.SelectedItem == null || comboBoxSecond.SelectedItem == null || comboBoxPeriod.SelectedItem == null)
            {
                System.Windows.Forms.MessageBox.Show("No added Alarm", "Alarm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                labelRemainingTimeValue.Text = "00:00:00";
            }
            else
            {
                timerAlarm.Enabled = false;
                comboBoxHour.Enabled = true;
                comboBoxMinutes.Enabled = true;
                comboBoxPeriod.Enabled = true;
                comboBoxSecond.Enabled = true;
                flag = false;
                labelIsAlarmSet.Text = "not set!";
                labelIsAlarmSet.ForeColor = System.Drawing.Color.Red;
                labelAlarmStatus.ForeColor = System.Drawing.Color.Red;
                System.Windows.Forms.MessageBox.Show("Alarm is removed!", "Alarm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                labelRemainingTimeValue.Text = "00:00:00";
            }
        }

        private void buttonStartWatch_Click(object sender, EventArgs e)
        {
            timerStopwatch.Start();
            timerStopWatchms.Start();
        }

        private void timerStopwatch_Tick(object sender, EventArgs e)
        {
            second++;
            if (second < 10)
            {
                labelSecondStopwatch.Text = "0" + second.ToString();
            }
            else if (second < 60)
            {
                labelSecondStopwatch.Text = second.ToString();
            }
            if (second == 60)
            {
                second = 0;
                if (second < 10)
                {
                    labelSecondStopwatch.Text = "0" + second.ToString();
                }
                minute++;
                if (minute < 10)
                {
                    labelMinuteStopwatch.Text = "0" + minute.ToString();
                }
                else if (minute < 60)
                {
                    labelMinuteStopwatch.Text = minute.ToString();
                }
            }

            if (minute == 60)
            {
                minute = 0;
                if (minute < 10)
                {
                    labelMinuteStopwatch.Text = "0" + minute.ToString();
                }
                hour++;
                if (hour < 10)
                {
                    labelStopwatchHour.Text = "0" + hour.ToString();
                }
                else
                {
                    labelStopwatchHour.Text = hour.ToString();
                }
            }
        }

        private void buttonStopWatch_Click(object sender, EventArgs e)
        {
            timerStopwatch.Stop();
            timerStopWatchms.Stop();
        }

        private void buttonResetStopWatch_Click(object sender, EventArgs e)
        {
            timerStopwatch.Stop();
            timerStopWatchms.Stop();
            labelSecondStopwatch.Text = "00";
            labelMinuteStopwatch.Text = "00";
            labelStopwatchHour.Text = "00";
            labelStopwatchMs.Text = "00";
            hour = 0;
            minute = 0;
            second = 0;
            ms = 0;
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            
            switch(e.KeyCode)
            {
                case Keys.F1:
                    System.Windows.Forms.MessageBox.Show("App Name: Alarm App \n\nApp version: 1.0.0\n\nCreator: Kamil Abiyev\n\nRelease Date: March 28, 2021.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case Keys.F2:
                    System.Windows.Forms.MessageBox.Show("You can use this app for basic timer stuffs. F.e. You can set time for alarm or use stopwatch for time races.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        private void timerStopWatchms_Tick(object sender, EventArgs e)
        {
            ms++;
            if (ms < 10)
            {
                labelStopwatchMs.Text = "0" + ms.ToString();
            } else if (ms < 60)
            {
                labelStopwatchMs.Text = ms.ToString();
            }
            if (ms == 60)
            {
                ms = 0;
                if (ms < 10)
                {
                    labelStopwatchMs.Text = "0" + ms.ToString();
                }
            }
        }
    }
}
