
namespace XokaFutebol
{
    partial class MatchFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatchFrame));
            this.pMatchHeader = new System.Windows.Forms.Panel();
            this.pScore = new System.Windows.Forms.Panel();
            this.lGameState = new System.Windows.Forms.Label();
            this.lTime = new System.Windows.Forms.Label();
            this.pAwayTeam = new System.Windows.Forms.Panel();
            this.lAwayPenScore = new System.Windows.Forms.Label();
            this.lAwayScore = new System.Windows.Forms.Label();
            this.lAwayName = new System.Windows.Forms.Label();
            this.lHomeScore = new System.Windows.Forms.Label();
            this.pHomeTeam = new System.Windows.Forms.Panel();
            this.lHomePenScore = new System.Windows.Forms.Label();
            this.lHomeName = new System.Windows.Forms.Label();
            this.matchTimer = new System.Windows.Forms.Timer(this.components);
            this.btnMatchStats = new System.Windows.Forms.Button();
            this.pHomePress = new System.Windows.Forms.Panel();
            this.pAwayPress = new System.Windows.Forms.Panel();
            this.lHomeEvents = new System.Windows.Forms.Label();
            this.pHomeEvents = new System.Windows.Forms.Panel();
            this.pAwayEvents = new System.Windows.Forms.Panel();
            this.lAwayEvents = new System.Windows.Forms.Label();
            this.picBolaScore = new System.Windows.Forms.PictureBox();
            this.pMatchInfo = new System.Windows.Forms.Panel();
            this.lMatchInfoStage = new System.Windows.Forms.Label();
            this.lMatchInfoType = new System.Windows.Forms.Label();
            this.lMatchInfoCity = new System.Windows.Forms.Label();
            this.lMatchInfoWeather = new System.Windows.Forms.Label();
            this.lMatchInfoDate = new System.Windows.Forms.Label();
            this.lMatchInfoAtt = new System.Windows.Forms.Label();
            this.lMatchInfoRef = new System.Windows.Forms.Label();
            this.lMatchInfoStadium = new System.Windows.Forms.Label();
            this.btnPitchView = new System.Windows.Forms.Button();
            this.btnOverview = new System.Windows.Forms.Button();
            this.btnScores = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.pHomeStats = new System.Windows.Forms.Panel();
            this.lHomeCoach = new System.Windows.Forms.Label();
            this.cbHomeStats = new System.Windows.Forms.ComboBox();
            this.pAwayStats = new System.Windows.Forms.Panel();
            this.lAwayCoach = new System.Windows.Forms.Label();
            this.cbAwayStats = new System.Windows.Forms.ComboBox();
            this.pTabs = new System.Windows.Forms.FlowLayoutPanel();
            this.pMatchStats = new System.Windows.Forms.Panel();
            this.lMatchStats = new System.Windows.Forms.Label();
            this.pMatchReport = new System.Windows.Forms.Panel();
            this.pPitchView = new System.Windows.Forms.Panel();
            this.bola = new System.Windows.Forms.PictureBox();
            this.lPitchHomeNames = new System.Windows.Forms.Label();
            this.lPitchAwayNames = new System.Windows.Forms.Label();
            this.pMatchHeader.SuspendLayout();
            this.pScore.SuspendLayout();
            this.pAwayTeam.SuspendLayout();
            this.pHomeTeam.SuspendLayout();
            this.pHomeEvents.SuspendLayout();
            this.pAwayEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBolaScore)).BeginInit();
            this.pMatchInfo.SuspendLayout();
            this.pHomeStats.SuspendLayout();
            this.pAwayStats.SuspendLayout();
            this.pTabs.SuspendLayout();
            this.pMatchStats.SuspendLayout();
            this.pPitchView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bola)).BeginInit();
            this.SuspendLayout();
            // 
            // pMatchHeader
            // 
            this.pMatchHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pMatchHeader.BackColor = System.Drawing.Color.Transparent;
            this.pMatchHeader.Controls.Add(this.pScore);
            this.pMatchHeader.Controls.Add(this.pAwayTeam);
            this.pMatchHeader.Location = new System.Drawing.Point(12, 12);
            this.pMatchHeader.Name = "pMatchHeader";
            this.pMatchHeader.Size = new System.Drawing.Size(1878, 130);
            this.pMatchHeader.TabIndex = 1;
            // 
            // pScore
            // 
            this.pScore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pScore.Controls.Add(this.lGameState);
            this.pScore.Controls.Add(this.lTime);
            this.pScore.Location = new System.Drawing.Point(795, 3);
            this.pScore.Name = "pScore";
            this.pScore.Size = new System.Drawing.Size(287, 127);
            this.pScore.TabIndex = 3;
            this.pScore.Click += new System.EventHandler(this.PScore_Click);
            this.pScore.MouseEnter += new System.EventHandler(this.PScore_MouseEnter);
            this.pScore.MouseLeave += new System.EventHandler(this.PScore_MouseLeave);
            // 
            // lGameState
            // 
            this.lGameState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lGameState.BackColor = System.Drawing.Color.Transparent;
            this.lGameState.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGameState.ForeColor = System.Drawing.Color.White;
            this.lGameState.Location = new System.Drawing.Point(45, 80);
            this.lGameState.Name = "lGameState";
            this.lGameState.Size = new System.Drawing.Size(199, 38);
            this.lGameState.TabIndex = 10;
            this.lGameState.Text = "Kick Off";
            this.lGameState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lGameState.Click += new System.EventHandler(this.PScore_Click);
            this.lGameState.MouseEnter += new System.EventHandler(this.PScore_MouseEnter);
            this.lGameState.MouseLeave += new System.EventHandler(this.PScore_MouseLeave);
            // 
            // lTime
            // 
            this.lTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lTime.BackColor = System.Drawing.Color.Transparent;
            this.lTime.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTime.ForeColor = System.Drawing.Color.White;
            this.lTime.Location = new System.Drawing.Point(45, 0);
            this.lTime.Name = "lTime";
            this.lTime.Size = new System.Drawing.Size(199, 80);
            this.lTime.TabIndex = 9;
            this.lTime.Text = "\'00";
            this.lTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lTime.Click += new System.EventHandler(this.PScore_Click);
            this.lTime.MouseEnter += new System.EventHandler(this.PScore_MouseEnter);
            this.lTime.MouseLeave += new System.EventHandler(this.PScore_MouseLeave);
            // 
            // pAwayTeam
            // 
            this.pAwayTeam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pAwayTeam.BackColor = System.Drawing.Color.Cyan;
            this.pAwayTeam.Controls.Add(this.lAwayPenScore);
            this.pAwayTeam.Controls.Add(this.lAwayScore);
            this.pAwayTeam.Controls.Add(this.lAwayName);
            this.pAwayTeam.Location = new System.Drawing.Point(1088, 0);
            this.pAwayTeam.Name = "pAwayTeam";
            this.pAwayTeam.Size = new System.Drawing.Size(787, 130);
            this.pAwayTeam.TabIndex = 2;
            this.pAwayTeam.Click += new System.EventHandler(this.CallAwayTactics);
            // 
            // lAwayPenScore
            // 
            this.lAwayPenScore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lAwayPenScore.BackColor = System.Drawing.Color.Transparent;
            this.lAwayPenScore.Font = new System.Drawing.Font("Microsoft YaHei", 37.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAwayPenScore.ForeColor = System.Drawing.Color.White;
            this.lAwayPenScore.Location = new System.Drawing.Point(125, 3);
            this.lAwayPenScore.Margin = new System.Windows.Forms.Padding(0);
            this.lAwayPenScore.Name = "lAwayPenScore";
            this.lAwayPenScore.Size = new System.Drawing.Size(158, 127);
            this.lAwayPenScore.TabIndex = 12;
            this.lAwayPenScore.Text = "(0)";
            this.lAwayPenScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lAwayPenScore.Visible = false;
            this.lAwayPenScore.Click += new System.EventHandler(this.CallAwayTactics);
            // 
            // lAwayScore
            // 
            this.lAwayScore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lAwayScore.BackColor = System.Drawing.Color.Transparent;
            this.lAwayScore.Font = new System.Drawing.Font("Microsoft YaHei", 58.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAwayScore.ForeColor = System.Drawing.Color.White;
            this.lAwayScore.Location = new System.Drawing.Point(0, 3);
            this.lAwayScore.Margin = new System.Windows.Forms.Padding(0);
            this.lAwayScore.Name = "lAwayScore";
            this.lAwayScore.Size = new System.Drawing.Size(238, 127);
            this.lAwayScore.TabIndex = 11;
            this.lAwayScore.Text = "0";
            this.lAwayScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lAwayScore.Click += new System.EventHandler(this.CallAwayTactics);
            // 
            // lAwayName
            // 
            this.lAwayName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lAwayName.BackColor = System.Drawing.Color.Transparent;
            this.lAwayName.Font = new System.Drawing.Font("Microsoft YaHei", 54F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAwayName.Location = new System.Drawing.Point(120, -7);
            this.lAwayName.Name = "lAwayName";
            this.lAwayName.Size = new System.Drawing.Size(670, 137);
            this.lAwayName.TabIndex = 0;
            this.lAwayName.Text = "Argentina";
            this.lAwayName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lAwayName.Click += new System.EventHandler(this.CallAwayTactics);
            // 
            // lHomeScore
            // 
            this.lHomeScore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lHomeScore.BackColor = System.Drawing.Color.Transparent;
            this.lHomeScore.Font = new System.Drawing.Font("Microsoft YaHei", 58.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHomeScore.ForeColor = System.Drawing.Color.Black;
            this.lHomeScore.Location = new System.Drawing.Point(580, 0);
            this.lHomeScore.Margin = new System.Windows.Forms.Padding(0);
            this.lHomeScore.Name = "lHomeScore";
            this.lHomeScore.Size = new System.Drawing.Size(209, 127);
            this.lHomeScore.TabIndex = 10;
            this.lHomeScore.Text = "0";
            this.lHomeScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lHomeScore.Click += new System.EventHandler(this.CallHomeTactics);
            // 
            // pHomeTeam
            // 
            this.pHomeTeam.BackColor = System.Drawing.Color.Yellow;
            this.pHomeTeam.Controls.Add(this.lHomePenScore);
            this.pHomeTeam.Controls.Add(this.lHomeScore);
            this.pHomeTeam.Controls.Add(this.lHomeName);
            this.pHomeTeam.Location = new System.Drawing.Point(12, 12);
            this.pHomeTeam.Name = "pHomeTeam";
            this.pHomeTeam.Size = new System.Drawing.Size(789, 130);
            this.pHomeTeam.TabIndex = 1;
            this.pHomeTeam.Click += new System.EventHandler(this.CallHomeTactics);
            // 
            // lHomePenScore
            // 
            this.lHomePenScore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lHomePenScore.BackColor = System.Drawing.Color.Transparent;
            this.lHomePenScore.Font = new System.Drawing.Font("Microsoft YaHei", 37.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHomePenScore.ForeColor = System.Drawing.Color.Maroon;
            this.lHomePenScore.Location = new System.Drawing.Point(461, 3);
            this.lHomePenScore.Margin = new System.Windows.Forms.Padding(0);
            this.lHomePenScore.Name = "lHomePenScore";
            this.lHomePenScore.Size = new System.Drawing.Size(209, 127);
            this.lHomePenScore.TabIndex = 11;
            this.lHomePenScore.Text = "(0)";
            this.lHomePenScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lHomePenScore.Visible = false;
            this.lHomePenScore.Click += new System.EventHandler(this.CallHomeTactics);
            // 
            // lHomeName
            // 
            this.lHomeName.BackColor = System.Drawing.Color.Transparent;
            this.lHomeName.Font = new System.Drawing.Font("Microsoft YaHei", 54F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHomeName.ForeColor = System.Drawing.Color.MediumBlue;
            this.lHomeName.Location = new System.Drawing.Point(0, -7);
            this.lHomeName.Name = "lHomeName";
            this.lHomeName.Size = new System.Drawing.Size(644, 137);
            this.lHomeName.TabIndex = 0;
            this.lHomeName.Text = "Brazilasd";
            this.lHomeName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lHomeName.Click += new System.EventHandler(this.CallHomeTactics);
            // 
            // matchTimer
            // 
            this.matchTimer.Interval = 10;
            this.matchTimer.Tick += new System.EventHandler(this.MatchTimer_Tick);
            // 
            // btnMatchStats
            // 
            this.btnMatchStats.AutoSize = true;
            this.btnMatchStats.BackColor = System.Drawing.Color.Transparent;
            this.btnMatchStats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMatchStats.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMatchStats.FlatAppearance.BorderSize = 3;
            this.btnMatchStats.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnMatchStats.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnMatchStats.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMatchStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatchStats.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatchStats.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMatchStats.Location = new System.Drawing.Point(5, 5);
            this.btnMatchStats.Margin = new System.Windows.Forms.Padding(5);
            this.btnMatchStats.Name = "btnMatchStats";
            this.btnMatchStats.Size = new System.Drawing.Size(369, 85);
            this.btnMatchStats.TabIndex = 9;
            this.btnMatchStats.Text = "Match Stats";
            this.btnMatchStats.UseVisualStyleBackColor = false;
            this.btnMatchStats.Click += new System.EventHandler(this.btnMatchStats_Click);
            // 
            // pHomePress
            // 
            this.pHomePress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pHomePress.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pHomePress.Location = new System.Drawing.Point(14, 964);
            this.pHomePress.Name = "pHomePress";
            this.pHomePress.Size = new System.Drawing.Size(928, 57);
            this.pHomePress.TabIndex = 10;
            // 
            // pAwayPress
            // 
            this.pAwayPress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pAwayPress.BackColor = System.Drawing.Color.Cyan;
            this.pAwayPress.Location = new System.Drawing.Point(14, 964);
            this.pAwayPress.Margin = new System.Windows.Forms.Padding(0);
            this.pAwayPress.Name = "pAwayPress";
            this.pAwayPress.Size = new System.Drawing.Size(1876, 57);
            this.pAwayPress.TabIndex = 12;
            // 
            // lHomeEvents
            // 
            this.lHomeEvents.BackColor = System.Drawing.Color.Transparent;
            this.lHomeEvents.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHomeEvents.ForeColor = System.Drawing.Color.White;
            this.lHomeEvents.Location = new System.Drawing.Point(20, 15);
            this.lHomeEvents.Name = "lHomeEvents";
            this.lHomeEvents.Size = new System.Drawing.Size(656, 640);
            this.lHomeEvents.TabIndex = 13;
            // 
            // pHomeEvents
            // 
            this.pHomeEvents.BackColor = System.Drawing.Color.Gray;
            this.pHomeEvents.Controls.Add(this.lHomeEvents);
            this.pHomeEvents.Location = new System.Drawing.Point(12, 195);
            this.pHomeEvents.Name = "pHomeEvents";
            this.pHomeEvents.Size = new System.Drawing.Size(687, 673);
            this.pHomeEvents.TabIndex = 15;
            // 
            // pAwayEvents
            // 
            this.pAwayEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pAwayEvents.BackColor = System.Drawing.Color.Gray;
            this.pAwayEvents.Controls.Add(this.lAwayEvents);
            this.pAwayEvents.Location = new System.Drawing.Point(1203, 195);
            this.pAwayEvents.Name = "pAwayEvents";
            this.pAwayEvents.Size = new System.Drawing.Size(687, 673);
            this.pAwayEvents.TabIndex = 18;
            // 
            // lAwayEvents
            // 
            this.lAwayEvents.BackColor = System.Drawing.Color.Transparent;
            this.lAwayEvents.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAwayEvents.ForeColor = System.Drawing.Color.White;
            this.lAwayEvents.Location = new System.Drawing.Point(20, 15);
            this.lAwayEvents.Name = "lAwayEvents";
            this.lAwayEvents.Size = new System.Drawing.Size(662, 640);
            this.lAwayEvents.TabIndex = 13;
            // 
            // picBolaScore
            // 
            this.picBolaScore.BackColor = System.Drawing.Color.Transparent;
            this.picBolaScore.Image = global::XokaFutebol.Properties.Resources.Xokafu_Bola_Big;
            this.picBolaScore.Location = new System.Drawing.Point(827, 29);
            this.picBolaScore.Name = "picBolaScore";
            this.picBolaScore.Size = new System.Drawing.Size(235, 213);
            this.picBolaScore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBolaScore.TabIndex = 20;
            this.picBolaScore.TabStop = false;
            this.picBolaScore.Click += new System.EventHandler(this.PScore_Click);
            this.picBolaScore.MouseEnter += new System.EventHandler(this.PScore_MouseEnter);
            this.picBolaScore.MouseLeave += new System.EventHandler(this.PScore_MouseLeave);
            // 
            // pMatchInfo
            // 
            this.pMatchInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pMatchInfo.BackColor = System.Drawing.Color.Transparent;
            this.pMatchInfo.Controls.Add(this.lMatchInfoStage);
            this.pMatchInfo.Controls.Add(this.lMatchInfoType);
            this.pMatchInfo.Controls.Add(this.lMatchInfoCity);
            this.pMatchInfo.Controls.Add(this.lMatchInfoWeather);
            this.pMatchInfo.Controls.Add(this.lMatchInfoDate);
            this.pMatchInfo.Controls.Add(this.lMatchInfoAtt);
            this.pMatchInfo.Controls.Add(this.lMatchInfoRef);
            this.pMatchInfo.Controls.Add(this.lMatchInfoStadium);
            this.pMatchInfo.Location = new System.Drawing.Point(705, 248);
            this.pMatchInfo.Name = "pMatchInfo";
            this.pMatchInfo.Size = new System.Drawing.Size(492, 603);
            this.pMatchInfo.TabIndex = 30;
            // 
            // lMatchInfoStage
            // 
            this.lMatchInfoStage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lMatchInfoStage.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMatchInfoStage.ForeColor = System.Drawing.Color.White;
            this.lMatchInfoStage.Location = new System.Drawing.Point(41, 95);
            this.lMatchInfoStage.Name = "lMatchInfoStage";
            this.lMatchInfoStage.Size = new System.Drawing.Size(416, 41);
            this.lMatchInfoStage.TabIndex = 37;
            this.lMatchInfoStage.Text = "Round of 16";
            this.lMatchInfoStage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lMatchInfoType
            // 
            this.lMatchInfoType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lMatchInfoType.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMatchInfoType.ForeColor = System.Drawing.Color.White;
            this.lMatchInfoType.Location = new System.Drawing.Point(41, 19);
            this.lMatchInfoType.Name = "lMatchInfoType";
            this.lMatchInfoType.Size = new System.Drawing.Size(416, 76);
            this.lMatchInfoType.TabIndex = 36;
            this.lMatchInfoType.Text = "World Cup";
            this.lMatchInfoType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lMatchInfoCity
            // 
            this.lMatchInfoCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lMatchInfoCity.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMatchInfoCity.ForeColor = System.Drawing.Color.White;
            this.lMatchInfoCity.Location = new System.Drawing.Point(40, 406);
            this.lMatchInfoCity.Name = "lMatchInfoCity";
            this.lMatchInfoCity.Size = new System.Drawing.Size(417, 40);
            this.lMatchInfoCity.TabIndex = 35;
            this.lMatchInfoCity.Text = "São Paulo, Brazil\r\n\r\n";
            this.lMatchInfoCity.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lMatchInfoWeather
            // 
            this.lMatchInfoWeather.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lMatchInfoWeather.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMatchInfoWeather.ForeColor = System.Drawing.Color.White;
            this.lMatchInfoWeather.Location = new System.Drawing.Point(39, 289);
            this.lMatchInfoWeather.Name = "lMatchInfoWeather";
            this.lMatchInfoWeather.Size = new System.Drawing.Size(416, 45);
            this.lMatchInfoWeather.TabIndex = 34;
            this.lMatchInfoWeather.Text = "Weather: Dry, 24°C";
            this.lMatchInfoWeather.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lMatchInfoDate
            // 
            this.lMatchInfoDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lMatchInfoDate.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMatchInfoDate.ForeColor = System.Drawing.Color.White;
            this.lMatchInfoDate.Location = new System.Drawing.Point(39, 244);
            this.lMatchInfoDate.Name = "lMatchInfoDate";
            this.lMatchInfoDate.Size = new System.Drawing.Size(416, 45);
            this.lMatchInfoDate.TabIndex = 33;
            this.lMatchInfoDate.Text = "Saturday 11/02/2021";
            this.lMatchInfoDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lMatchInfoAtt
            // 
            this.lMatchInfoAtt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lMatchInfoAtt.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMatchInfoAtt.ForeColor = System.Drawing.Color.White;
            this.lMatchInfoAtt.Location = new System.Drawing.Point(39, 446);
            this.lMatchInfoAtt.Name = "lMatchInfoAtt";
            this.lMatchInfoAtt.Size = new System.Drawing.Size(417, 33);
            this.lMatchInfoAtt.TabIndex = 32;
            this.lMatchInfoAtt.Text = "Attendance: 45.000";
            this.lMatchInfoAtt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lMatchInfoRef
            // 
            this.lMatchInfoRef.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lMatchInfoRef.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMatchInfoRef.ForeColor = System.Drawing.Color.White;
            this.lMatchInfoRef.Location = new System.Drawing.Point(36, 515);
            this.lMatchInfoRef.Name = "lMatchInfoRef";
            this.lMatchInfoRef.Size = new System.Drawing.Size(415, 33);
            this.lMatchInfoRef.TabIndex = 31;
            this.lMatchInfoRef.Text = "Referee: Edílson Pereira de Carvalho\r\n";
            this.lMatchInfoRef.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lMatchInfoStadium
            // 
            this.lMatchInfoStadium.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lMatchInfoStadium.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMatchInfoStadium.ForeColor = System.Drawing.Color.White;
            this.lMatchInfoStadium.Location = new System.Drawing.Point(40, 365);
            this.lMatchInfoStadium.Name = "lMatchInfoStadium";
            this.lMatchInfoStadium.Size = new System.Drawing.Size(417, 41);
            this.lMatchInfoStadium.TabIndex = 30;
            this.lMatchInfoStadium.Text = "Estádio do Morumbi\r\n";
            this.lMatchInfoStadium.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnPitchView
            // 
            this.btnPitchView.AutoSize = true;
            this.btnPitchView.BackColor = System.Drawing.Color.Transparent;
            this.btnPitchView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPitchView.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPitchView.FlatAppearance.BorderSize = 3;
            this.btnPitchView.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnPitchView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPitchView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPitchView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPitchView.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPitchView.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPitchView.Location = new System.Drawing.Point(384, 5);
            this.btnPitchView.Margin = new System.Windows.Forms.Padding(5);
            this.btnPitchView.Name = "btnPitchView";
            this.btnPitchView.Size = new System.Drawing.Size(364, 85);
            this.btnPitchView.TabIndex = 31;
            this.btnPitchView.Text = "Pitch View";
            this.btnPitchView.UseVisualStyleBackColor = false;
            this.btnPitchView.Click += new System.EventHandler(this.btnPitchView_Click);
            // 
            // btnOverview
            // 
            this.btnOverview.AutoSize = true;
            this.btnOverview.BackColor = System.Drawing.Color.Transparent;
            this.btnOverview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOverview.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOverview.FlatAppearance.BorderSize = 3;
            this.btnOverview.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnOverview.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnOverview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOverview.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOverview.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOverview.Location = new System.Drawing.Point(758, 5);
            this.btnOverview.Margin = new System.Windows.Forms.Padding(5);
            this.btnOverview.Name = "btnOverview";
            this.btnOverview.Size = new System.Drawing.Size(364, 85);
            this.btnOverview.TabIndex = 32;
            this.btnOverview.Text = "Overview";
            this.btnOverview.UseVisualStyleBackColor = false;
            this.btnOverview.Click += new System.EventHandler(this.BtnMatchOverview_Click);
            // 
            // btnScores
            // 
            this.btnScores.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnScores.AutoSize = true;
            this.btnScores.BackColor = System.Drawing.Color.Transparent;
            this.btnScores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScores.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnScores.FlatAppearance.BorderSize = 3;
            this.btnScores.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnScores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnScores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnScores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScores.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScores.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnScores.Location = new System.Drawing.Point(1506, 5);
            this.btnScores.Margin = new System.Windows.Forms.Padding(5);
            this.btnScores.Name = "btnScores";
            this.btnScores.Size = new System.Drawing.Size(364, 85);
            this.btnScores.TabIndex = 33;
            this.btnScores.Text = "Latest Scores";
            this.btnScores.UseVisualStyleBackColor = false;
            // 
            // btnReport
            // 
            this.btnReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReport.AutoSize = true;
            this.btnReport.BackColor = System.Drawing.Color.Transparent;
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReport.FlatAppearance.BorderSize = 3;
            this.btnReport.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReport.Location = new System.Drawing.Point(1132, 5);
            this.btnReport.Margin = new System.Windows.Forms.Padding(5);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(364, 85);
            this.btnReport.TabIndex = 34;
            this.btnReport.Text = "Match Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // pHomeStats
            // 
            this.pHomeStats.BackColor = System.Drawing.Color.Gray;
            this.pHomeStats.Controls.Add(this.lHomeCoach);
            this.pHomeStats.Controls.Add(this.cbHomeStats);
            this.pHomeStats.Location = new System.Drawing.Point(12, 172);
            this.pHomeStats.Name = "pHomeStats";
            this.pHomeStats.Size = new System.Drawing.Size(687, 70);
            this.pHomeStats.TabIndex = 16;
            this.pHomeStats.Visible = false;
            // 
            // lHomeCoach
            // 
            this.lHomeCoach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lHomeCoach.AutoSize = true;
            this.lHomeCoach.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHomeCoach.Location = new System.Drawing.Point(14, -520);
            this.lHomeCoach.Name = "lHomeCoach";
            this.lHomeCoach.Size = new System.Drawing.Size(167, 31);
            this.lHomeCoach.TabIndex = 16;
            this.lHomeCoach.Text = "Coach Name";
            // 
            // cbHomeStats
            // 
            this.cbHomeStats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbHomeStats.BackColor = System.Drawing.Color.Yellow;
            this.cbHomeStats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHomeStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbHomeStats.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHomeStats.FormattingEnabled = true;
            this.cbHomeStats.Items.AddRange(new object[] {
            "Position",
            "Rating",
            "Condition",
            "Goals",
            "Assists",
            "Shots On Target",
            "Shots",
            "Passes Attempted",
            "Passes Completed",
            "Offsides",
            "Tackles",
            "Fouls",
            "Yellow Cards",
            "Red Cards"});
            this.cbHomeStats.Location = new System.Drawing.Point(428, 9);
            this.cbHomeStats.Name = "cbHomeStats";
            this.cbHomeStats.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbHomeStats.Size = new System.Drawing.Size(247, 35);
            this.cbHomeStats.TabIndex = 15;
            this.cbHomeStats.SelectedIndexChanged += new System.EventHandler(this.cbHomeStats_SelectedIndexChanged);
            // 
            // pAwayStats
            // 
            this.pAwayStats.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pAwayStats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pAwayStats.BackColor = System.Drawing.Color.Gray;
            this.pAwayStats.Controls.Add(this.lAwayCoach);
            this.pAwayStats.Controls.Add(this.cbAwayStats);
            this.pAwayStats.Location = new System.Drawing.Point(1203, 172);
            this.pAwayStats.Name = "pAwayStats";
            this.pAwayStats.Size = new System.Drawing.Size(684, 70);
            this.pAwayStats.TabIndex = 17;
            this.pAwayStats.Visible = false;
            // 
            // lAwayCoach
            // 
            this.lAwayCoach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lAwayCoach.AutoSize = true;
            this.lAwayCoach.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAwayCoach.Location = new System.Drawing.Point(12, -520);
            this.lAwayCoach.Name = "lAwayCoach";
            this.lAwayCoach.Size = new System.Drawing.Size(167, 31);
            this.lAwayCoach.TabIndex = 18;
            this.lAwayCoach.Text = "Coach Name";
            // 
            // cbAwayStats
            // 
            this.cbAwayStats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAwayStats.BackColor = System.Drawing.Color.Yellow;
            this.cbAwayStats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAwayStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAwayStats.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAwayStats.FormattingEnabled = true;
            this.cbAwayStats.Items.AddRange(new object[] {
            "Position",
            "Rating",
            "Condition",
            "Goals",
            "Assists",
            "Shots On Target",
            "Shots",
            "Passes Attempted",
            "Passes Completed",
            "Offsides",
            "Tackles",
            "Fouls",
            "Yellow Cards",
            "Red Cards"});
            this.cbAwayStats.Location = new System.Drawing.Point(425, 9);
            this.cbAwayStats.Name = "cbAwayStats";
            this.cbAwayStats.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbAwayStats.Size = new System.Drawing.Size(247, 35);
            this.cbAwayStats.TabIndex = 16;
            this.cbAwayStats.SelectedIndexChanged += new System.EventHandler(this.cbAwayStats_SelectedIndexChanged);
            // 
            // pTabs
            // 
            this.pTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pTabs.BackColor = System.Drawing.Color.Transparent;
            this.pTabs.Controls.Add(this.btnMatchStats);
            this.pTabs.Controls.Add(this.btnPitchView);
            this.pTabs.Controls.Add(this.btnOverview);
            this.pTabs.Controls.Add(this.btnReport);
            this.pTabs.Controls.Add(this.btnScores);
            this.pTabs.Location = new System.Drawing.Point(5, 871);
            this.pTabs.Name = "pTabs";
            this.pTabs.Size = new System.Drawing.Size(1898, 90);
            this.pTabs.TabIndex = 35;
            // 
            // pMatchStats
            // 
            this.pMatchStats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pMatchStats.BackColor = System.Drawing.Color.Transparent;
            this.pMatchStats.Controls.Add(this.lMatchStats);
            this.pMatchStats.Location = new System.Drawing.Point(705, 233);
            this.pMatchStats.Name = "pMatchStats";
            this.pMatchStats.Size = new System.Drawing.Size(492, 603);
            this.pMatchStats.TabIndex = 36;
            this.pMatchStats.Visible = false;
            // 
            // lMatchStats
            // 
            this.lMatchStats.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lMatchStats.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMatchStats.ForeColor = System.Drawing.Color.White;
            this.lMatchStats.Location = new System.Drawing.Point(3, 30);
            this.lMatchStats.Name = "lMatchStats";
            this.lMatchStats.Size = new System.Drawing.Size(486, 605);
            this.lMatchStats.TabIndex = 31;
            this.lMatchStats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pMatchReport
            // 
            this.pMatchReport.AutoScroll = true;
            this.pMatchReport.BackColor = System.Drawing.Color.Gray;
            this.pMatchReport.Location = new System.Drawing.Point(15, 159);
            this.pMatchReport.Name = "pMatchReport";
            this.pMatchReport.Size = new System.Drawing.Size(1872, 709);
            this.pMatchReport.TabIndex = 37;
            this.pMatchReport.Visible = false;
            // 
            // pPitchView
            // 
            this.pPitchView.BackColor = System.Drawing.Color.Gray;
            this.pPitchView.BackgroundImage = global::XokaFutebol.Properties.Resources.soccer_field;
            this.pPitchView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pPitchView.Controls.Add(this.bola);
            this.pPitchView.Location = new System.Drawing.Point(5, 172);
            this.pPitchView.Name = "pPitchView";
            this.pPitchView.Size = new System.Drawing.Size(1872, 685);
            this.pPitchView.TabIndex = 38;
            this.pPitchView.Visible = false;
            // 
            // bola
            // 
            this.bola.BackColor = System.Drawing.Color.Transparent;
            this.bola.Image = global::XokaFutebol.Properties.Resources.Xokafu_Bola_Small;
            this.bola.Location = new System.Drawing.Point(921, 320);
            this.bola.Name = "bola";
            this.bola.Size = new System.Drawing.Size(26, 27);
            this.bola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bola.TabIndex = 0;
            this.bola.TabStop = false;
            // 
            // lPitchHomeNames
            // 
            this.lPitchHomeNames.AutoSize = true;
            this.lPitchHomeNames.BackColor = System.Drawing.Color.Transparent;
            this.lPitchHomeNames.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPitchHomeNames.ForeColor = System.Drawing.Color.Transparent;
            this.lPitchHomeNames.Location = new System.Drawing.Point(-18, 118);
            this.lPitchHomeNames.Name = "lPitchHomeNames";
            this.lPitchHomeNames.Size = new System.Drawing.Size(73, 27);
            this.lPitchHomeNames.TabIndex = 39;
            this.lPitchHomeNames.Text = "label1";
            this.lPitchHomeNames.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lPitchHomeNames.Visible = false;
            // 
            // lPitchAwayNames
            // 
            this.lPitchAwayNames.AutoSize = true;
            this.lPitchAwayNames.BackColor = System.Drawing.Color.Transparent;
            this.lPitchAwayNames.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPitchAwayNames.ForeColor = System.Drawing.Color.Transparent;
            this.lPitchAwayNames.Location = new System.Drawing.Point(-18, 96);
            this.lPitchAwayNames.Name = "lPitchAwayNames";
            this.lPitchAwayNames.Size = new System.Drawing.Size(73, 27);
            this.lPitchAwayNames.TabIndex = 40;
            this.lPitchAwayNames.Text = "label1";
            this.lPitchAwayNames.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lPitchAwayNames.Visible = false;
            // 
            // MatchFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.BackgroundImage = global::XokaFutebol.Properties.Resources.pnghost_football_pitch_stadium_arena_soccer_field_arena_lawn;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.lPitchAwayNames);
            this.Controls.Add(this.lPitchHomeNames);
            this.Controls.Add(this.pPitchView);
            this.Controls.Add(this.pMatchReport);
            this.Controls.Add(this.pMatchStats);
            this.Controls.Add(this.pTabs);
            this.Controls.Add(this.pAwayStats);
            this.Controls.Add(this.pHomeStats);
            this.Controls.Add(this.pMatchInfo);
            this.Controls.Add(this.pHomeEvents);
            this.Controls.Add(this.pAwayEvents);
            this.Controls.Add(this.pHomeTeam);
            this.Controls.Add(this.pHomePress);
            this.Controls.Add(this.pAwayPress);
            this.Controls.Add(this.pMatchHeader);
            this.Controls.Add(this.picBolaScore);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MatchFrame";
            this.Text = "XokaFut - New Game";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MatchFrame_Load);
            this.pMatchHeader.ResumeLayout(false);
            this.pScore.ResumeLayout(false);
            this.pAwayTeam.ResumeLayout(false);
            this.pHomeTeam.ResumeLayout(false);
            this.pHomeEvents.ResumeLayout(false);
            this.pAwayEvents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBolaScore)).EndInit();
            this.pMatchInfo.ResumeLayout(false);
            this.pHomeStats.ResumeLayout(false);
            this.pHomeStats.PerformLayout();
            this.pAwayStats.ResumeLayout(false);
            this.pAwayStats.PerformLayout();
            this.pTabs.ResumeLayout(false);
            this.pTabs.PerformLayout();
            this.pMatchStats.ResumeLayout(false);
            this.pPitchView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bola)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pMatchHeader;
        private System.Windows.Forms.Panel pHomeTeam;
        private System.Windows.Forms.Panel pAwayTeam;
        private System.Windows.Forms.Panel pScore;
        private System.Windows.Forms.Label lAwayName;
        private System.Windows.Forms.Label lHomeName;
        private System.Windows.Forms.Timer matchTimer;
        private System.Windows.Forms.Label lTime;
        private System.Windows.Forms.Label lAwayScore;
        private System.Windows.Forms.Label lHomeScore;
        private System.Windows.Forms.Button btnMatchStats;
        private System.Windows.Forms.Panel pHomePress;
        private System.Windows.Forms.Panel pAwayPress;
        private System.Windows.Forms.Label lHomeEvents;
        private System.Windows.Forms.Panel pHomeEvents;
        private System.Windows.Forms.Panel pAwayEvents;
        private System.Windows.Forms.Label lAwayEvents;
        private System.Windows.Forms.PictureBox picBolaScore;
        private System.Windows.Forms.Label lGameState;
        private System.Windows.Forms.Label lAwayPenScore;
        private System.Windows.Forms.Label lHomePenScore;
        private System.Windows.Forms.Panel pMatchInfo;
        private System.Windows.Forms.Label lMatchInfoStage;
        private System.Windows.Forms.Label lMatchInfoType;
        private System.Windows.Forms.Label lMatchInfoCity;
        private System.Windows.Forms.Label lMatchInfoWeather;
        private System.Windows.Forms.Label lMatchInfoDate;
        private System.Windows.Forms.Label lMatchInfoAtt;
        private System.Windows.Forms.Label lMatchInfoRef;
        private System.Windows.Forms.Label lMatchInfoStadium;
        private System.Windows.Forms.Button btnPitchView;
        private System.Windows.Forms.Button btnOverview;
        private System.Windows.Forms.Button btnScores;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Panel pHomeStats;
        private System.Windows.Forms.Panel pAwayStats;
        private System.Windows.Forms.FlowLayoutPanel pTabs;
        private System.Windows.Forms.ComboBox cbHomeStats;
        private System.Windows.Forms.ComboBox cbAwayStats;
        private System.Windows.Forms.Label lHomeCoach;
        private System.Windows.Forms.Label lAwayCoach;
        private System.Windows.Forms.Panel pMatchStats;
        private System.Windows.Forms.Label lMatchStats;
        private System.Windows.Forms.Panel pMatchReport;
        private System.Windows.Forms.Panel pPitchView;
        private System.Windows.Forms.PictureBox bola;
        private System.Windows.Forms.Label lPitchHomeNames;
        private System.Windows.Forms.Label lPitchAwayNames;
    }
}