
namespace XokaFutebol
{
    partial class introFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(introFrame));
            this.pMainMenu = new System.Windows.Forms.Panel();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnEditor = new System.Windows.Forms.Button();
            this.btnLoadGame = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.pNewGame = new System.Windows.Forms.Panel();
            this.cbSeasons = new System.Windows.Forms.ComboBox();
            this.cbGameMode = new System.Windows.Forms.ComboBox();
            this.lGameMode = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.cbPlayerTeam = new System.Windows.Forms.ComboBox();
            this.tbPlayerName = new System.Windows.Forms.MaskedTextBox();
            this.lPickName = new System.Windows.Forms.Label();
            this.lPickSeason = new System.Windows.Forms.Label();
            this.lPickTeam = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.lNewGameTitle = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.picBola = new System.Windows.Forms.PictureBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pMainMenu.SuspendLayout();
            this.pNewGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pMainMenu
            // 
            this.pMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.pMainMenu.Controls.Add(this.btnQuit);
            this.pMainMenu.Controls.Add(this.btnHelp);
            this.pMainMenu.Controls.Add(this.btnSettings);
            this.pMainMenu.Controls.Add(this.btnEditor);
            this.pMainMenu.Controls.Add(this.btnLoadGame);
            this.pMainMenu.Controls.Add(this.btnNewGame);
            this.pMainMenu.Location = new System.Drawing.Point(103, 740);
            this.pMainMenu.Name = "pMainMenu";
            this.pMainMenu.Size = new System.Drawing.Size(1141, 593);
            this.pMainMenu.TabIndex = 8;
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQuit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnQuit.BackColor = System.Drawing.Color.Transparent;
            this.btnQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnQuit.FlatAppearance.BorderSize = 3;
            this.btnQuit.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnQuit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQuit.Location = new System.Drawing.Point(691, 406);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(403, 129);
            this.btnQuit.TabIndex = 13;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHelp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHelp.FlatAppearance.BorderSize = 3;
            this.btnHelp.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHelp.Location = new System.Drawing.Point(691, 230);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(4);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(403, 129);
            this.btnHelp.TabIndex = 12;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSettings.FlatAppearance.BorderSize = 3;
            this.btnSettings.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSettings.Location = new System.Drawing.Point(691, 54);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(403, 129);
            this.btnSettings.TabIndex = 11;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            // 
            // btnEditor
            // 
            this.btnEditor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditor.BackColor = System.Drawing.Color.Transparent;
            this.btnEditor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditor.FlatAppearance.BorderSize = 3;
            this.btnEditor.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnEditor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEditor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditor.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditor.Location = new System.Drawing.Point(34, 406);
            this.btnEditor.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditor.Name = "btnEditor";
            this.btnEditor.Size = new System.Drawing.Size(403, 129);
            this.btnEditor.TabIndex = 10;
            this.btnEditor.Text = "Editor";
            this.btnEditor.UseVisualStyleBackColor = false;
            // 
            // btnLoadGame
            // 
            this.btnLoadGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLoadGame.BackColor = System.Drawing.Color.Transparent;
            this.btnLoadGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadGame.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLoadGame.FlatAppearance.BorderSize = 3;
            this.btnLoadGame.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnLoadGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLoadGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLoadGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadGame.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadGame.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLoadGame.Location = new System.Drawing.Point(34, 230);
            this.btnLoadGame.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadGame.Name = "btnLoadGame";
            this.btnLoadGame.Size = new System.Drawing.Size(403, 129);
            this.btnLoadGame.TabIndex = 9;
            this.btnLoadGame.Text = "Load";
            this.btnLoadGame.UseVisualStyleBackColor = false;
            this.btnLoadGame.Click += new System.EventHandler(this.BtnLoadGame_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNewGame.BackColor = System.Drawing.Color.Transparent;
            this.btnNewGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewGame.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNewGame.FlatAppearance.BorderSize = 3;
            this.btnNewGame.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnNewGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnNewGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNewGame.Location = new System.Drawing.Point(34, 54);
            this.btnNewGame.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(403, 129);
            this.btnNewGame.TabIndex = 8;
            this.btnNewGame.Text = "New";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.BtnNewGame_Click);
            // 
            // pNewGame
            // 
            this.pNewGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pNewGame.BackColor = System.Drawing.Color.Transparent;
            this.pNewGame.Controls.Add(this.cbSeasons);
            this.pNewGame.Controls.Add(this.cbGameMode);
            this.pNewGame.Controls.Add(this.lGameMode);
            this.pNewGame.Controls.Add(this.btnBack);
            this.pNewGame.Controls.Add(this.btnStart);
            this.pNewGame.Controls.Add(this.cbPlayerTeam);
            this.pNewGame.Controls.Add(this.tbPlayerName);
            this.pNewGame.Controls.Add(this.lPickName);
            this.pNewGame.Controls.Add(this.lPickSeason);
            this.pNewGame.Controls.Add(this.lPickTeam);
            this.pNewGame.Controls.Add(this.l);
            this.pNewGame.Controls.Add(this.lNewGameTitle);
            this.pNewGame.Location = new System.Drawing.Point(373, 397);
            this.pNewGame.Name = "pNewGame";
            this.pNewGame.Size = new System.Drawing.Size(1141, 593);
            this.pNewGame.TabIndex = 9;
            this.pNewGame.Visible = false;
            // 
            // cbSeasons
            // 
            this.cbSeasons.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSeasons.BackColor = System.Drawing.Color.White;
            this.cbSeasons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSeasons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSeasons.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSeasons.FormattingEnabled = true;
            this.cbSeasons.Items.AddRange(new object[] {
            "1997/1998"});
            this.cbSeasons.Location = new System.Drawing.Point(513, 397);
            this.cbSeasons.Name = "cbSeasons";
            this.cbSeasons.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbSeasons.Size = new System.Drawing.Size(405, 44);
            this.cbSeasons.TabIndex = 7;
            // 
            // cbGameMode
            // 
            this.cbGameMode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbGameMode.BackColor = System.Drawing.Color.White;
            this.cbGameMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGameMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbGameMode.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGameMode.FormattingEnabled = true;
            this.cbGameMode.Items.AddRange(new object[] {
            "Random Friendly",
            "Random Cup"});
            this.cbGameMode.Location = new System.Drawing.Point(513, 313);
            this.cbGameMode.Name = "cbGameMode";
            this.cbGameMode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbGameMode.Size = new System.Drawing.Size(405, 44);
            this.cbGameMode.TabIndex = 3;
            // 
            // lGameMode
            // 
            this.lGameMode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lGameMode.AutoSize = true;
            this.lGameMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lGameMode.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGameMode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lGameMode.Location = new System.Drawing.Point(243, 313);
            this.lGameMode.Name = "lGameMode";
            this.lGameMode.Size = new System.Drawing.Size(222, 44);
            this.lGameMode.TabIndex = 0;
            this.lGameMode.Text = "Game Mode";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.BorderSize = 3;
            this.btnBack.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBack.Location = new System.Drawing.Point(616, 501);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(322, 65);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStart.BackColor = System.Drawing.Color.White;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStart.FlatAppearance.BorderSize = 3;
            this.btnStart.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnStart.Location = new System.Drawing.Point(207, 501);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(322, 65);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // cbPlayerTeam
            // 
            this.cbPlayerTeam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbPlayerTeam.BackColor = System.Drawing.Color.White;
            this.cbPlayerTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlayerTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPlayerTeam.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPlayerTeam.FormattingEnabled = true;
            this.cbPlayerTeam.Location = new System.Drawing.Point(513, 227);
            this.cbPlayerTeam.Name = "cbPlayerTeam";
            this.cbPlayerTeam.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbPlayerTeam.Size = new System.Drawing.Size(405, 44);
            this.cbPlayerTeam.TabIndex = 2;
            // 
            // tbPlayerName
            // 
            this.tbPlayerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPlayerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPlayerName.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPlayerName.Location = new System.Drawing.Point(513, 141);
            this.tbPlayerName.Name = "tbPlayerName";
            this.tbPlayerName.Size = new System.Drawing.Size(405, 43);
            this.tbPlayerName.TabIndex = 1;
            // 
            // lPickName
            // 
            this.lPickName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lPickName.AutoSize = true;
            this.lPickName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lPickName.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPickName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lPickName.Location = new System.Drawing.Point(239, 141);
            this.lPickName.Name = "lPickName";
            this.lPickName.Size = new System.Drawing.Size(226, 44);
            this.lPickName.TabIndex = 0;
            this.lPickName.Text = "Pick a Name";
            // 
            // lPickSeason
            // 
            this.lPickSeason.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lPickSeason.AutoSize = true;
            this.lPickSeason.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lPickSeason.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPickSeason.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lPickSeason.Location = new System.Drawing.Point(220, 397);
            this.lPickSeason.Name = "lPickSeason";
            this.lPickSeason.Size = new System.Drawing.Size(245, 44);
            this.lPickSeason.TabIndex = 0;
            this.lPickSeason.Text = "Pick a Season";
            // 
            // lPickTeam
            // 
            this.lPickTeam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lPickTeam.AutoSize = true;
            this.lPickTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lPickTeam.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPickTeam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lPickTeam.Location = new System.Drawing.Point(246, 227);
            this.lPickTeam.Name = "lPickTeam";
            this.lPickTeam.Size = new System.Drawing.Size(219, 44);
            this.lPickTeam.TabIndex = 0;
            this.lPickTeam.Text = "Pick a Team";
            // 
            // l
            // 
            this.l.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(148, 163);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(46, 17);
            this.l.TabIndex = 1;
            this.l.Text = "label1";
            // 
            // lNewGameTitle
            // 
            this.lNewGameTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lNewGameTitle.AutoSize = true;
            this.lNewGameTitle.BackColor = System.Drawing.Color.DarkOrange;
            this.lNewGameTitle.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNewGameTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lNewGameTitle.Location = new System.Drawing.Point(388, -1);
            this.lNewGameTitle.Name = "lNewGameTitle";
            this.lNewGameTitle.Size = new System.Drawing.Size(364, 80);
            this.lNewGameTitle.TabIndex = 0;
            this.lNewGameTitle.Text = "New Game";
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelTitle.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 139.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTitle.Location = new System.Drawing.Point(470, 32);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(989, 269);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "XokaFuteb ol";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBola
            // 
            this.picBola.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.picBola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBola.Image = global::XokaFutebol.Properties.Resources.Xokafu_Bola_Big;
            this.picBola.Location = new System.Drawing.Point(1222, 132);
            this.picBola.Margin = new System.Windows.Forms.Padding(0);
            this.picBola.Name = "picBola";
            this.picBola.Size = new System.Drawing.Size(131, 125);
            this.picBola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBola.TabIndex = 11;
            this.picBola.TabStop = false;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 1000;
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // introFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImage = global::XokaFutebol.Properties.Resources.pnghost_football_pitch_stadium_arena_soccer_field_arena_lawn;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.picBola);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pNewGame);
            this.Controls.Add(this.pMainMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "introFrame";
            this.Text = "XokaFut";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.IntroForm_Load);
            this.pMainMenu.ResumeLayout(false);
            this.pNewGame.ResumeLayout(false);
            this.pNewGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pMainMenu;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnEditor;
        private System.Windows.Forms.Button btnLoadGame;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Panel pNewGame;
        private System.Windows.Forms.Label lNewGameTitle;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cbPlayerTeam;
        private System.Windows.Forms.MaskedTextBox tbPlayerName;
        private System.Windows.Forms.Label lPickName;
        private System.Windows.Forms.Label lPickSeason;
        private System.Windows.Forms.Label lPickTeam;
        private System.Windows.Forms.PictureBox picBola;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ComboBox cbGameMode;
        private System.Windows.Forms.Label lGameMode;
        private System.Windows.Forms.ComboBox cbSeasons;
    }
}

