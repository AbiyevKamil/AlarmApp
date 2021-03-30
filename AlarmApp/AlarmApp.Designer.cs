
namespace AlarmApp
{
    partial class AlarmApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlarmApp));
            this.panelTop = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelCurrentTimeValue = new System.Windows.Forms.Label();
            this.labelCurrentDate = new System.Windows.Forms.Label();
            this.labelCurrentDateValue = new System.Windows.Forms.Label();
            this.labelCurrentTime = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.comboBoxHour = new System.Windows.Forms.ComboBox();
            this.labelHour = new System.Windows.Forms.Label();
            this.labelMinute = new System.Windows.Forms.Label();
            this.comboBoxMinutes = new System.Windows.Forms.ComboBox();
            this.labelSeconds = new System.Windows.Forms.Label();
            this.comboBoxSecond = new System.Windows.Forms.ComboBox();
            this.timerCurrentTime = new System.Windows.Forms.Timer(this.components);
            this.labelAlarmStatus = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelFunctionalKeys = new System.Windows.Forms.Panel();
            this.labelHelp = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelIsAlarmSet = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonAddAlarm = new System.Windows.Forms.Button();
            this.timerAlarm = new System.Windows.Forms.Timer(this.components);
            this.panelAlarmStatus = new System.Windows.Forms.Panel();
            this.comboBoxPeriod = new System.Windows.Forms.ComboBox();
            this.labelPeriod = new System.Windows.Forms.Label();
            this.buttonRemoveAlarm = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.labelRemainingTime = new System.Windows.Forms.Label();
            this.panelMainLeft = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayerAlarm = new AxWMPLib.AxWindowsMediaPlayer();
            this.axWindowsMediaPlayerTiktak = new AxWMPLib.AxWindowsMediaPlayer();
            this.labelRemainingTimeValue = new System.Windows.Forms.Label();
            this.panelMainRight = new System.Windows.Forms.Panel();
            this.labelStopwatchMs = new System.Windows.Forms.Label();
            this.labelSemicolonThird = new System.Windows.Forms.Label();
            this.buttonResetStopWatch = new System.Windows.Forms.Button();
            this.labelSecondStopwatch = new System.Windows.Forms.Label();
            this.labelSemicolonSecond = new System.Windows.Forms.Label();
            this.labelMinuteStopwatch = new System.Windows.Forms.Label();
            this.labelSemicolonFirst = new System.Windows.Forms.Label();
            this.labelStopwatchHour = new System.Windows.Forms.Label();
            this.buttonStopWatch = new System.Windows.Forms.Button();
            this.buttonStartWatch = new System.Windows.Forms.Button();
            this.labelStopWatch = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timerStopwatch = new System.Windows.Forms.Timer(this.components);
            this.timerStopWatchms = new System.Windows.Forms.Timer(this.components);
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.panelFunctionalKeys.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelMainLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerAlarm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerTiktak)).BeginInit();
            this.panelMainRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Transparent;
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop.Controls.Add(this.pictureBoxLogo);
            this.panelTop.Controls.Add(this.labelCurrentTimeValue);
            this.panelTop.Controls.Add(this.labelCurrentDate);
            this.panelTop.Controls.Add(this.labelCurrentDateValue);
            this.panelTop.Controls.Add(this.labelCurrentTime);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(988, 72);
            this.panelTop.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.White;
            this.pictureBoxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.BackgroundImage")));
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo.Location = new System.Drawing.Point(-1, -1);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(196, 72);
            this.pictureBoxLogo.TabIndex = 7;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelCurrentTimeValue
            // 
            this.labelCurrentTimeValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCurrentTimeValue.AutoSize = true;
            this.labelCurrentTimeValue.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentTimeValue.ForeColor = System.Drawing.Color.Yellow;
            this.labelCurrentTimeValue.Location = new System.Drawing.Point(436, 24);
            this.labelCurrentTimeValue.Name = "labelCurrentTimeValue";
            this.labelCurrentTimeValue.Size = new System.Drawing.Size(0, 27);
            this.labelCurrentTimeValue.TabIndex = 7;
            // 
            // labelCurrentDate
            // 
            this.labelCurrentDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCurrentDate.AutoSize = true;
            this.labelCurrentDate.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentDate.ForeColor = System.Drawing.Color.Yellow;
            this.labelCurrentDate.Location = new System.Drawing.Point(601, 24);
            this.labelCurrentDate.Name = "labelCurrentDate";
            this.labelCurrentDate.Size = new System.Drawing.Size(157, 27);
            this.labelCurrentDate.TabIndex = 6;
            this.labelCurrentDate.Text = "Current Date:";
            this.labelCurrentDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelCurrentDateValue
            // 
            this.labelCurrentDateValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCurrentDateValue.AutoSize = true;
            this.labelCurrentDateValue.ForeColor = System.Drawing.Color.Yellow;
            this.labelCurrentDateValue.Location = new System.Drawing.Point(733, 24);
            this.labelCurrentDateValue.Name = "labelCurrentDateValue";
            this.labelCurrentDateValue.Size = new System.Drawing.Size(0, 27);
            this.labelCurrentDateValue.TabIndex = 6;
            this.labelCurrentDateValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelCurrentTime
            // 
            this.labelCurrentTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCurrentTime.AutoSize = true;
            this.labelCurrentTime.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentTime.ForeColor = System.Drawing.Color.Yellow;
            this.labelCurrentTime.Location = new System.Drawing.Point(302, 24);
            this.labelCurrentTime.Name = "labelCurrentTime";
            this.labelCurrentTime.Size = new System.Drawing.Size(158, 27);
            this.labelCurrentTime.TabIndex = 4;
            this.labelCurrentTime.Text = "Current Time:";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.Transparent;
            this.labelTime.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelTime.Location = new System.Drawing.Point(7, 131);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(107, 27);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "Set time:";
            // 
            // comboBoxHour
            // 
            this.comboBoxHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHour.FormattingEnabled = true;
            this.comboBoxHour.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBoxHour.Location = new System.Drawing.Point(117, 131);
            this.comboBoxHour.Name = "comboBoxHour";
            this.comboBoxHour.Size = new System.Drawing.Size(65, 34);
            this.comboBoxHour.TabIndex = 9;
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.BackColor = System.Drawing.Color.Transparent;
            this.labelHour.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelHour.Location = new System.Drawing.Point(112, 90);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(76, 27);
            this.labelHour.TabIndex = 10;
            this.labelHour.Text = "Hours";
            // 
            // labelMinute
            // 
            this.labelMinute.AutoSize = true;
            this.labelMinute.BackColor = System.Drawing.Color.Transparent;
            this.labelMinute.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMinute.Location = new System.Drawing.Point(205, 90);
            this.labelMinute.Name = "labelMinute";
            this.labelMinute.Size = new System.Drawing.Size(96, 27);
            this.labelMinute.TabIndex = 11;
            this.labelMinute.Text = "Minutes";
            // 
            // comboBoxMinutes
            // 
            this.comboBoxMinutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMinutes.FormattingEnabled = true;
            this.comboBoxMinutes.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "00"});
            this.comboBoxMinutes.Location = new System.Drawing.Point(210, 132);
            this.comboBoxMinutes.Name = "comboBoxMinutes";
            this.comboBoxMinutes.Size = new System.Drawing.Size(71, 34);
            this.comboBoxMinutes.TabIndex = 12;
            // 
            // labelSeconds
            // 
            this.labelSeconds.AutoSize = true;
            this.labelSeconds.BackColor = System.Drawing.Color.Transparent;
            this.labelSeconds.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSeconds.Location = new System.Drawing.Point(312, 90);
            this.labelSeconds.Name = "labelSeconds";
            this.labelSeconds.Size = new System.Drawing.Size(106, 27);
            this.labelSeconds.TabIndex = 13;
            this.labelSeconds.Text = "Seconds";
            // 
            // comboBoxSecond
            // 
            this.comboBoxSecond.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSecond.FormattingEnabled = true;
            this.comboBoxSecond.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "00"});
            this.comboBoxSecond.Location = new System.Drawing.Point(322, 132);
            this.comboBoxSecond.Name = "comboBoxSecond";
            this.comboBoxSecond.Size = new System.Drawing.Size(69, 34);
            this.comboBoxSecond.TabIndex = 14;
            // 
            // timerCurrentTime
            // 
            this.timerCurrentTime.Interval = 1000;
            this.timerCurrentTime.Tick += new System.EventHandler(this.timerCurrentTime_Tick);
            // 
            // labelAlarmStatus
            // 
            this.labelAlarmStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelAlarmStatus.AutoSize = true;
            this.labelAlarmStatus.ForeColor = System.Drawing.Color.Red;
            this.labelAlarmStatus.Location = new System.Drawing.Point(6, 22);
            this.labelAlarmStatus.Name = "labelAlarmStatus";
            this.labelAlarmStatus.Size = new System.Drawing.Size(98, 27);
            this.labelAlarmStatus.TabIndex = 2;
            this.labelAlarmStatus.Text = "Alarm is";
            this.labelAlarmStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.Transparent;
            this.panelBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBottom.Controls.Add(this.panelFunctionalKeys);
            this.panelBottom.Controls.Add(this.labelIsAlarmSet);
            this.panelBottom.Controls.Add(this.labelAlarmStatus);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 406);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(0);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(988, 72);
            this.panelBottom.TabIndex = 1;
            // 
            // panelFunctionalKeys
            // 
            this.panelFunctionalKeys.Controls.Add(this.labelHelp);
            this.panelFunctionalKeys.Controls.Add(this.labelInfo);
            this.panelFunctionalKeys.Location = new System.Drawing.Point(209, -1);
            this.panelFunctionalKeys.Name = "panelFunctionalKeys";
            this.panelFunctionalKeys.Size = new System.Drawing.Size(774, 72);
            this.panelFunctionalKeys.TabIndex = 4;
            // 
            // labelHelp
            // 
            this.labelHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHelp.AutoSize = true;
            this.labelHelp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHelp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelHelp.Location = new System.Drawing.Point(413, 23);
            this.labelHelp.Name = "labelHelp";
            this.labelHelp.Size = new System.Drawing.Size(162, 23);
            this.labelHelp.TabIndex = 1;
            this.labelHelp.Text = "Press F2 for help";
            // 
            // labelInfo
            // 
            this.labelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelInfo.Location = new System.Drawing.Point(132, 23);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(157, 23);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "Press F1 for info";
            // 
            // labelIsAlarmSet
            // 
            this.labelIsAlarmSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelIsAlarmSet.AutoSize = true;
            this.labelIsAlarmSet.ForeColor = System.Drawing.Color.Red;
            this.labelIsAlarmSet.Location = new System.Drawing.Point(81, 22);
            this.labelIsAlarmSet.Name = "labelIsAlarmSet";
            this.labelIsAlarmSet.Size = new System.Drawing.Size(93, 27);
            this.labelIsAlarmSet.TabIndex = 3;
            this.labelIsAlarmSet.Text = "not set!";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(196, 129);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(303, 34);
            this.textBoxTitle.TabIndex = 15;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTitle.Location = new System.Drawing.Point(7, 201);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(126, 27);
            this.labelTitle.TabIndex = 16;
            this.labelTitle.Text = "Alarm title:";
            // 
            // buttonAddAlarm
            // 
            this.buttonAddAlarm.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddAlarm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddAlarm.FlatAppearance.BorderSize = 0;
            this.buttonAddAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddAlarm.ForeColor = System.Drawing.Color.Green;
            this.buttonAddAlarm.Location = new System.Drawing.Point(356, 189);
            this.buttonAddAlarm.Name = "buttonAddAlarm";
            this.buttonAddAlarm.Size = new System.Drawing.Size(142, 56);
            this.buttonAddAlarm.TabIndex = 17;
            this.buttonAddAlarm.Text = "Add Alarm";
            this.buttonAddAlarm.UseVisualStyleBackColor = false;
            this.buttonAddAlarm.Click += new System.EventHandler(this.buttonAddAlarm_Click);
            // 
            // timerAlarm
            // 
            this.timerAlarm.Interval = 1000;
            this.timerAlarm.Tick += new System.EventHandler(this.timerAlarm_Tick);
            // 
            // panelAlarmStatus
            // 
            this.panelAlarmStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelAlarmStatus.BackColor = System.Drawing.Color.Transparent;
            this.panelAlarmStatus.Location = new System.Drawing.Point(4, 406);
            this.panelAlarmStatus.Name = "panelAlarmStatus";
            this.panelAlarmStatus.Size = new System.Drawing.Size(200, 72);
            this.panelAlarmStatus.TabIndex = 18;
            // 
            // comboBoxPeriod
            // 
            this.comboBoxPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPeriod.FormattingEnabled = true;
            this.comboBoxPeriod.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.comboBoxPeriod.Location = new System.Drawing.Point(428, 132);
            this.comboBoxPeriod.Name = "comboBoxPeriod";
            this.comboBoxPeriod.Size = new System.Drawing.Size(70, 34);
            this.comboBoxPeriod.TabIndex = 19;
            // 
            // labelPeriod
            // 
            this.labelPeriod.AutoSize = true;
            this.labelPeriod.BackColor = System.Drawing.Color.Transparent;
            this.labelPeriod.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPeriod.Location = new System.Drawing.Point(423, 90);
            this.labelPeriod.Name = "labelPeriod";
            this.labelPeriod.Size = new System.Drawing.Size(81, 27);
            this.labelPeriod.TabIndex = 20;
            this.labelPeriod.Text = "Period";
            // 
            // buttonRemoveAlarm
            // 
            this.buttonRemoveAlarm.BackColor = System.Drawing.Color.Transparent;
            this.buttonRemoveAlarm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemoveAlarm.FlatAppearance.BorderSize = 0;
            this.buttonRemoveAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveAlarm.ForeColor = System.Drawing.Color.Crimson;
            this.buttonRemoveAlarm.Location = new System.Drawing.Point(149, 189);
            this.buttonRemoveAlarm.Name = "buttonRemoveAlarm";
            this.buttonRemoveAlarm.Size = new System.Drawing.Size(175, 56);
            this.buttonRemoveAlarm.TabIndex = 21;
            this.buttonRemoveAlarm.Text = "Remove Alarm";
            this.buttonRemoveAlarm.UseVisualStyleBackColor = false;
            this.buttonRemoveAlarm.Click += new System.EventHandler(this.buttonRemoveAlarm_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.Controls.Add(this.labelPeriod);
            this.panelMain.Controls.Add(this.comboBoxPeriod);
            this.panelMain.Controls.Add(this.labelHour);
            this.panelMain.Controls.Add(this.labelRemainingTime);
            this.panelMain.Controls.Add(this.comboBoxMinutes);
            this.panelMain.Controls.Add(this.labelMinute);
            this.panelMain.Controls.Add(this.labelSeconds);
            this.panelMain.Controls.Add(this.comboBoxSecond);
            this.panelMain.Controls.Add(this.comboBoxHour);
            this.panelMain.Controls.Add(this.panelMainLeft);
            this.panelMain.Controls.Add(this.panelMainRight);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(988, 478);
            this.panelMain.TabIndex = 22;
            // 
            // labelRemainingTime
            // 
            this.labelRemainingTime.AutoSize = true;
            this.labelRemainingTime.ForeColor = System.Drawing.Color.Red;
            this.labelRemainingTime.Location = new System.Drawing.Point(13, 366);
            this.labelRemainingTime.Name = "labelRemainingTime";
            this.labelRemainingTime.Size = new System.Drawing.Size(186, 27);
            this.labelRemainingTime.TabIndex = 0;
            this.labelRemainingTime.Text = "Remaining time:";
            // 
            // panelMainLeft
            // 
            this.panelMainLeft.Controls.Add(this.axWindowsMediaPlayerAlarm);
            this.panelMainLeft.Controls.Add(this.axWindowsMediaPlayerTiktak);
            this.panelMainLeft.Controls.Add(this.buttonRemoveAlarm);
            this.panelMainLeft.Controls.Add(this.textBoxTitle);
            this.panelMainLeft.Controls.Add(this.buttonAddAlarm);
            this.panelMainLeft.Controls.Add(this.labelRemainingTimeValue);
            this.panelMainLeft.Location = new System.Drawing.Point(0, 69);
            this.panelMainLeft.Name = "panelMainLeft";
            this.panelMainLeft.Size = new System.Drawing.Size(607, 334);
            this.panelMainLeft.TabIndex = 21;
            // 
            // axWindowsMediaPlayerAlarm
            // 
            this.axWindowsMediaPlayerAlarm.Enabled = true;
            this.axWindowsMediaPlayerAlarm.Location = new System.Drawing.Point(12, 189);
            this.axWindowsMediaPlayerAlarm.Name = "axWindowsMediaPlayerAlarm";
            this.axWindowsMediaPlayerAlarm.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayerAlarm.OcxState")));
            this.axWindowsMediaPlayerAlarm.Size = new System.Drawing.Size(96, 44);
            this.axWindowsMediaPlayerAlarm.TabIndex = 2;
            this.axWindowsMediaPlayerAlarm.Visible = false;
            // 
            // axWindowsMediaPlayerTiktak
            // 
            this.axWindowsMediaPlayerTiktak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.axWindowsMediaPlayerTiktak.Enabled = true;
            this.axWindowsMediaPlayerTiktak.Location = new System.Drawing.Point(12, 239);
            this.axWindowsMediaPlayerTiktak.Name = "axWindowsMediaPlayerTiktak";
            this.axWindowsMediaPlayerTiktak.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayerTiktak.OcxState")));
            this.axWindowsMediaPlayerTiktak.Size = new System.Drawing.Size(96, 55);
            this.axWindowsMediaPlayerTiktak.TabIndex = 22;
            this.axWindowsMediaPlayerTiktak.Visible = false;
            // 
            // labelRemainingTimeValue
            // 
            this.labelRemainingTimeValue.AutoSize = true;
            this.labelRemainingTimeValue.ForeColor = System.Drawing.Color.Red;
            this.labelRemainingTimeValue.Location = new System.Drawing.Point(205, 297);
            this.labelRemainingTimeValue.Name = "labelRemainingTimeValue";
            this.labelRemainingTimeValue.Size = new System.Drawing.Size(104, 27);
            this.labelRemainingTimeValue.TabIndex = 1;
            this.labelRemainingTimeValue.Text = "00:00:00";
            // 
            // panelMainRight
            // 
            this.panelMainRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMainRight.Controls.Add(this.labelStopwatchMs);
            this.panelMainRight.Controls.Add(this.labelSemicolonThird);
            this.panelMainRight.Controls.Add(this.buttonResetStopWatch);
            this.panelMainRight.Controls.Add(this.labelSecondStopwatch);
            this.panelMainRight.Controls.Add(this.labelSemicolonSecond);
            this.panelMainRight.Controls.Add(this.labelMinuteStopwatch);
            this.panelMainRight.Controls.Add(this.labelSemicolonFirst);
            this.panelMainRight.Controls.Add(this.labelStopwatchHour);
            this.panelMainRight.Controls.Add(this.buttonStopWatch);
            this.panelMainRight.Controls.Add(this.buttonStartWatch);
            this.panelMainRight.Controls.Add(this.labelStopWatch);
            this.panelMainRight.Location = new System.Drawing.Point(607, 69);
            this.panelMainRight.Name = "panelMainRight";
            this.panelMainRight.Size = new System.Drawing.Size(381, 334);
            this.panelMainRight.TabIndex = 23;
            // 
            // labelStopwatchMs
            // 
            this.labelStopwatchMs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStopwatchMs.AutoSize = true;
            this.labelStopwatchMs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelStopwatchMs.Location = new System.Drawing.Point(270, 82);
            this.labelStopwatchMs.Name = "labelStopwatchMs";
            this.labelStopwatchMs.Size = new System.Drawing.Size(38, 27);
            this.labelStopwatchMs.TabIndex = 31;
            this.labelStopwatchMs.Text = "00";
            // 
            // labelSemicolonThird
            // 
            this.labelSemicolonThird.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSemicolonThird.AutoSize = true;
            this.labelSemicolonThird.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSemicolonThird.Location = new System.Drawing.Point(246, 82);
            this.labelSemicolonThird.Name = "labelSemicolonThird";
            this.labelSemicolonThird.Size = new System.Drawing.Size(19, 27);
            this.labelSemicolonThird.TabIndex = 30;
            this.labelSemicolonThird.Text = ":";
            // 
            // buttonResetStopWatch
            // 
            this.buttonResetStopWatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonResetStopWatch.BackColor = System.Drawing.Color.Transparent;
            this.buttonResetStopWatch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonResetStopWatch.FlatAppearance.BorderSize = 0;
            this.buttonResetStopWatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResetStopWatch.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonResetStopWatch.Location = new System.Drawing.Point(122, 207);
            this.buttonResetStopWatch.Name = "buttonResetStopWatch";
            this.buttonResetStopWatch.Size = new System.Drawing.Size(129, 52);
            this.buttonResetStopWatch.TabIndex = 29;
            this.buttonResetStopWatch.Text = "Reset";
            this.buttonResetStopWatch.UseVisualStyleBackColor = false;
            this.buttonResetStopWatch.Click += new System.EventHandler(this.buttonResetStopWatch_Click);
            // 
            // labelSecondStopwatch
            // 
            this.labelSecondStopwatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSecondStopwatch.AutoSize = true;
            this.labelSecondStopwatch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSecondStopwatch.Location = new System.Drawing.Point(207, 82);
            this.labelSecondStopwatch.Name = "labelSecondStopwatch";
            this.labelSecondStopwatch.Size = new System.Drawing.Size(38, 27);
            this.labelSecondStopwatch.TabIndex = 28;
            this.labelSecondStopwatch.Text = "00";
            // 
            // labelSemicolonSecond
            // 
            this.labelSemicolonSecond.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSemicolonSecond.AutoSize = true;
            this.labelSemicolonSecond.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSemicolonSecond.Location = new System.Drawing.Point(183, 82);
            this.labelSemicolonSecond.Name = "labelSemicolonSecond";
            this.labelSemicolonSecond.Size = new System.Drawing.Size(19, 27);
            this.labelSemicolonSecond.TabIndex = 27;
            this.labelSemicolonSecond.Text = ":";
            // 
            // labelMinuteStopwatch
            // 
            this.labelMinuteStopwatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMinuteStopwatch.AutoSize = true;
            this.labelMinuteStopwatch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMinuteStopwatch.Location = new System.Drawing.Point(141, 82);
            this.labelMinuteStopwatch.Name = "labelMinuteStopwatch";
            this.labelMinuteStopwatch.Size = new System.Drawing.Size(38, 27);
            this.labelMinuteStopwatch.TabIndex = 26;
            this.labelMinuteStopwatch.Text = "00";
            // 
            // labelSemicolonFirst
            // 
            this.labelSemicolonFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSemicolonFirst.AutoSize = true;
            this.labelSemicolonFirst.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSemicolonFirst.Location = new System.Drawing.Point(117, 82);
            this.labelSemicolonFirst.Name = "labelSemicolonFirst";
            this.labelSemicolonFirst.Size = new System.Drawing.Size(19, 27);
            this.labelSemicolonFirst.TabIndex = 25;
            this.labelSemicolonFirst.Text = ":";
            // 
            // labelStopwatchHour
            // 
            this.labelStopwatchHour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStopwatchHour.AutoSize = true;
            this.labelStopwatchHour.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelStopwatchHour.Location = new System.Drawing.Point(75, 82);
            this.labelStopwatchHour.Name = "labelStopwatchHour";
            this.labelStopwatchHour.Size = new System.Drawing.Size(38, 27);
            this.labelStopwatchHour.TabIndex = 24;
            this.labelStopwatchHour.Text = "00";
            // 
            // buttonStopWatch
            // 
            this.buttonStopWatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStopWatch.BackColor = System.Drawing.Color.Transparent;
            this.buttonStopWatch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStopWatch.FlatAppearance.BorderSize = 0;
            this.buttonStopWatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStopWatch.ForeColor = System.Drawing.Color.Red;
            this.buttonStopWatch.Location = new System.Drawing.Point(212, 145);
            this.buttonStopWatch.Name = "buttonStopWatch";
            this.buttonStopWatch.Size = new System.Drawing.Size(133, 56);
            this.buttonStopWatch.TabIndex = 22;
            this.buttonStopWatch.Text = "Stop";
            this.buttonStopWatch.UseVisualStyleBackColor = false;
            this.buttonStopWatch.Click += new System.EventHandler(this.buttonStopWatch_Click);
            // 
            // buttonStartWatch
            // 
            this.buttonStartWatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStartWatch.BackColor = System.Drawing.Color.Transparent;
            this.buttonStartWatch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStartWatch.FlatAppearance.BorderSize = 0;
            this.buttonStartWatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartWatch.ForeColor = System.Drawing.Color.Green;
            this.buttonStartWatch.Location = new System.Drawing.Point(21, 145);
            this.buttonStartWatch.Name = "buttonStartWatch";
            this.buttonStartWatch.Size = new System.Drawing.Size(131, 56);
            this.buttonStartWatch.TabIndex = 18;
            this.buttonStartWatch.Text = "Start";
            this.buttonStartWatch.UseVisualStyleBackColor = false;
            this.buttonStartWatch.Click += new System.EventHandler(this.buttonStartWatch_Click);
            // 
            // labelStopWatch
            // 
            this.labelStopWatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStopWatch.AutoSize = true;
            this.labelStopWatch.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStopWatch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelStopWatch.Location = new System.Drawing.Point(119, 21);
            this.labelStopWatch.Name = "labelStopWatch";
            this.labelStopWatch.Size = new System.Drawing.Size(132, 33);
            this.labelStopWatch.TabIndex = 0;
            this.labelStopWatch.Text = "Stopwatch";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-28, -57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 22;
            // 
            // timerStopwatch
            // 
            this.timerStopwatch.Interval = 1000;
            this.timerStopwatch.Tick += new System.EventHandler(this.timerStopwatch_Tick);
            // 
            // timerStopWatchms
            // 
            this.timerStopWatchms.Interval = 10;
            this.timerStopWatchms.Tick += new System.EventHandler(this.timerStopWatchms_Tick);
            // 
            // AlarmApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(988, 478);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelAlarmStatus);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "AlarmApp";
            this.Text = "Alarm";
            this.Load += new System.EventHandler(this.Main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.panelFunctionalKeys.ResumeLayout(false);
            this.panelFunctionalKeys.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelMainLeft.ResumeLayout(false);
            this.panelMainLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerAlarm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerTiktak)).EndInit();
            this.panelMainRight.ResumeLayout(false);
            this.panelMainRight.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelCurrentTime;
        private System.Windows.Forms.Label labelCurrentDate;
        private System.Windows.Forms.Label labelCurrentDateValue;
        private System.Windows.Forms.Label labelCurrentTimeValue;
        private System.Windows.Forms.ComboBox comboBoxHour;
        private System.Windows.Forms.Label labelHour;
        private System.Windows.Forms.Label labelMinute;
        private System.Windows.Forms.ComboBox comboBoxMinutes;
        private System.Windows.Forms.Label labelSeconds;
        private System.Windows.Forms.ComboBox comboBoxSecond;
        private System.Windows.Forms.Timer timerCurrentTime;
        private System.Windows.Forms.Label labelAlarmStatus;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonAddAlarm;
        private System.Windows.Forms.Timer timerAlarm;
        private System.Windows.Forms.Label labelIsAlarmSet;
        private System.Windows.Forms.Panel panelAlarmStatus;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.ComboBox comboBoxPeriod;
        private System.Windows.Forms.Label labelPeriod;
        private System.Windows.Forms.Button buttonRemoveAlarm;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelRemainingTime;
        private System.Windows.Forms.Label labelRemainingTimeValue;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayerAlarm;
        private System.Windows.Forms.Panel panelMainLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMainRight;
        private System.Windows.Forms.Label labelStopWatch;
        private System.Windows.Forms.Button buttonStartWatch;
        private System.Windows.Forms.Button buttonStopWatch;
        private System.Windows.Forms.Timer timerStopwatch;
        private System.Windows.Forms.Label labelStopwatchHour;
        private System.Windows.Forms.Label labelSemicolonFirst;
        private System.Windows.Forms.Label labelSecondStopwatch;
        private System.Windows.Forms.Label labelSemicolonSecond;
        private System.Windows.Forms.Label labelMinuteStopwatch;
        private System.Windows.Forms.Button buttonResetStopWatch;
        private System.Windows.Forms.Panel panelFunctionalKeys;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelHelp;
        private System.Windows.Forms.Timer timerStopWatchms;
        private System.Windows.Forms.Label labelStopwatchMs;
        private System.Windows.Forms.Label labelSemicolonThird;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayerTiktak;
    }
}

