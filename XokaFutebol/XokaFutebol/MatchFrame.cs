using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XokaFutebol
{
    public partial class MatchFrame : Form
    {
        Obj.Match match;
        //Here are the two teams and these objects hold all the information concerning the teams
        //including: colors, names, lists of players, penalty takers, goals scored and substitutions
        Obj.Team homeTeam, awayTeam;
        //basic variables to keep track of the graphics and time
        int homePress, awayPress, pressSize, counter;
        //here all the random stuff that Hatsu controls
        int goalTarget, randomPlay;
        //some booleans to keep track of the game flow
        bool isExtraTime, isPenalties, isHomeAttacking; //homeShot, awayShot;
        int offset;
        
        readonly Color GREEN = Color.FromArgb(0, 192, 0);
        readonly Color DARK_GREEN = Color.FromArgb(0, 162, 0);
        readonly Color RED = Color.FromArgb(235, 0, 0);
        readonly Color DARK_RED = Color.FromArgb(205, 0, 0);
        int currentTab = 2; //0 stats, 1 unknown, 2 overview, 3 live scores, 4 match details
        
        public MatchFrame(Obj.Match match)
        {
            InitializeComponent();
            this.match = match;
            this.homeTeam = match.homeTeam;
            this.awayTeam = match.awayTeam;
            
        }

        private void MatchFrame_Load(object sender, EventArgs e)
        {
            offset = Width / 100;
            FixGraphics();
            isExtraTime = isPenalties = true;
            pScore.Cursor = lTime.Cursor = lGameState.Cursor = picBolaScore.Cursor =
                pHomeTeam.Cursor = pAwayTeam.Cursor = Cursors.Hand;
            InitializeTeamComponents();
            InitializeMatchInfo();
            UpdateTeamComponents(homeTeam, true);
            UpdateTeamComponents(awayTeam, false);
        }

        private void UpdateTeamComponents(Obj.Team team, bool isHome)
        {
            
            if (team.PlayerPanels != null)
            {
                for (int i = 0; i < team.PlayerPanels.Count; i++)
                {
                    team.PlayerPanels[i].Dispose();
                    if (i < 11)
                        team.PlayerButtons[i].Dispose();
                }
                team.PlayerPanels.Clear();
                team.PlayerButtons.Clear();
            }
            team.PlayerPanels = GeneratePlayerPanels(team);
            team.PlayerButtons = GeneratePlayerButtons(team);
            placeButtonsInFormation(team, isHome);
            UpdatePitchNames(team, isHome);
        }

        private void UpdatePitchNames(Obj.Team team, bool isHome)
        {
            team.GraphController.LPitchNames.Text = "";
            team.GraphController.LPitchNames.Text += "First Team:\n";
            for (int i = 0; i < 11; i ++)
            {
                team.GraphController.LPitchNames.Text += team.FirstTeam[i].Shirt_number + " - " + 
                    team.FirstTeam[i].Nickname + "\n";
            }
            /*
            team.GraphController.LPitchNames.Text += "\nBench:\n";
            for (int i = 0; i < match.MaxBench; i++)
            {
                team.GraphController.LPitchNames.Text += team.Bench[i].Shirt_number + " - " +
                    team.Bench[i].Nickname + "\n";
            }*/
        }

        private void FixGraphics()
        {
            picBolaScore.Size = new Size(Width / 9, Width / 9);
            int centerPoint = Width / 2 - picBolaScore.Width / 2;
            picBolaScore.Location = new Point(centerPoint, offset);
            pHomePress.Width = Width / 2 - (offset * 2);
            pAwayPress.Width = Width - (offset * 2);
            int bottomPoint = Height - pHomePress.Height - offset;
            pHomePress.Location = pAwayPress.Location = new Point(offset, bottomPoint);
            pressSize = pAwayPress.Width;
            lMatchInfoType.BackColor = lMatchInfoStage.BackColor = lMatchInfoCity.BackColor =
                lMatchInfoWeather.BackColor = lMatchInfoRef.BackColor = lMatchInfoDate.BackColor =
                lMatchInfoAtt.BackColor = lMatchInfoStadium.BackColor = pAwayEvents.BackColor =
                pHomeEvents.BackColor = pHomeStats.BackColor = pAwayStats.BackColor =
                lMatchStats.BackColor = pMatchReport.BackColor = lPitchAwayNames.BackColor = 
                lPitchHomeNames.BackColor = Color.FromArgb(100, Color.Black);
            btnMatchStats.Width = Width / 5 - offset * 2 / 3;
            btnPitchView.Width = btnOverview.Width = btnReport.Width = btnScores.Width = btnMatchStats.Width;
            pHomeStats.Top = pAwayStats.Top = pHomeTeam.Bottom + offset;
            pHomeStats.Height = pMatchReport.Height = pAwayStats.Height =
                Height - pHomeTeam.Height - btnReport.Height - pHomePress.Height - offset * 4;
            pHomeStats.Width = pAwayStats.Width = pHomeEvents.Width - offset / 2;
            pMatchStats.Width = pMatchInfo.Width;
            pMatchReport.Width = Width - offset * 2;
            pPitchView.Size = new Size(Width - offset * 24, pMatchReport.Height);
            pPitchView.Location = new Point(Width / 2 - pPitchView.Width / 2, pHomeTeam.Bottom + offset);
            pMatchStats.Left = pHomeStats.Right + offset / 2;
            pAwayStats.Left = pMatchStats.Right + offset / 2;
            lAwayCoach.Top = lHomeCoach.Top = cbAwayStats.Top = cbHomeStats.Top = 5;
            lPitchHomeNames.Location = new Point(pHomeTeam.Left, pHomeTeam.Bottom + offset);
            lPitchAwayNames.Location = new Point(pPitchView.Right, pHomeTeam.Bottom + offset);
            bola.Location = new Point(pPitchView.Width / 2 - bola.Width / 2, pPitchView.Height / 2 - bola.Height / 2);
        }

        private void InitializeTeamComponents()
        {
            //now we give the Teams their respective graphic controllers
            homeTeam.GraphController.LTeamName = lHomeName;
            homeTeam.GraphController.LMatchScore = lHomeScore;
            homeTeam.GraphController.LPenaltyScore = lHomePenScore;
            homeTeam.GraphController.LMatchEvents = lHomeEvents;
            homeTeam.GraphController.PEvents = pHomeEvents;
            homeTeam.GraphController.PHeader = pHomeTeam;
            homeTeam.GraphController.PPress = pHomePress;
            homeTeam.GraphController.PStats = pHomeStats;
            homeTeam.GraphController.CbSquadStats = cbHomeStats;
            homeTeam.GraphController.LCoachName = lHomeCoach;
            homeTeam.GraphController.LPitchNames = lPitchHomeNames;
            homeTeam.UpdateAllGraphs();

            //here we check to avoid conflicting colors
            if (homeTeam.TeamInfo.backcolor == awayTeam.TeamInfo.backcolor)
            {
                string tempColor = awayTeam.TeamInfo.backcolor;
                awayTeam.TeamInfo.backcolor = awayTeam.TeamInfo.forecolor;
                awayTeam.TeamInfo.forecolor = tempColor;
            }
            awayTeam.GraphController.LTeamName = lAwayName;
            awayTeam.GraphController.LMatchScore = lAwayScore;
            awayTeam.GraphController.LPenaltyScore = lAwayPenScore;
            awayTeam.GraphController.LMatchEvents = lAwayEvents;
            awayTeam.GraphController.PEvents = pAwayEvents;
            awayTeam.GraphController.PHeader = pAwayTeam;
            awayTeam.GraphController.PPress = pAwayPress;
            awayTeam.GraphController.PStats = pAwayStats;
            awayTeam.GraphController.CbSquadStats = cbAwayStats;
            awayTeam.GraphController.LCoachName = lAwayCoach;
            awayTeam.GraphController.LPitchNames = lPitchAwayNames;
            awayTeam.UpdateAllGraphs();
        }

        private IList<PlayerPanel> GeneratePlayerPanels(Obj.Team team)
        {
            IList<PlayerPanel> playerPanels = new List<PlayerPanel>();
            int size = pHomeStats.Width - offset * 4;
            int startY = 50, panelHeight = 27, gridPoints = 11 + match.MaxBench;
            bool isFirstTeam = true;
            for (int i = 0; i < 11 + match.MaxBench; i++)
            {
                if (i >= 11) isFirstTeam = false;
                playerPanels.Add(new PlayerPanel(team.TeamOrder[i], size, gridPoints, isFirstTeam, false));
                team.GraphController.PStats.Controls.Add(playerPanels.Last());
                playerPanels.Last().Location = new Point(offset, startY + panelHeight * i);
            }
            return playerPanels;
        }

        private void placeButtonsInFormation(Obj.Team team, bool isGoalHome)
        {
            int startX, startY;
            if (isGoalHome)
            {
                startX = offset * 8;
                startY = 70;
            }
            else
            {
                startX = pPitchView.Width - offset * 10;
                startY = pPitchView.Height - offset * 7;
            }
            int posGrid, posY, posX;
            for (int i = 0; i < 11; i++)
            {
                posGrid = team.Coach.Formation.Pos_coords[i];
                posX = posGrid / 10;
                posY = posGrid % 10;
                if (isGoalHome) team.PlayerButtons[i].Location = new Point(startX + posX * offset * 3, 
                    startY + posY * offset * 9 / 2);
                else team.PlayerButtons[i].Location = new Point(startX - posX * offset * 3,
                    startY - posY * offset * 9 / 2);
            }
        }

        private IList<RoundButton> GeneratePlayerButtons(Obj.Team team)
        {
            IList<RoundButton> playerButtons = new List<RoundButton>();
            foreach (Obj.Player player in team.FirstTeam)
            {
                playerButtons.Add(new RoundButton(player, team.TeamInfo));
                pPitchView.Controls.Add(playerButtons.Last());
            }
            return playerButtons;
        }

        

        private void InitializeMatchInfo()
        {
            lMatchInfoAtt.Text = match.Attendance;
            lMatchInfoCity.Text = match.City;
            lMatchInfoType.Text = match.MatchType;
            lMatchInfoDate.Text = match.Date;
            lMatchInfoRef.Text = match.Referee;
            lMatchInfoStadium.Text = match.Stadium;
            lMatchInfoStage.Text = match.MatchStage;
            lMatchInfoWeather.Text = match.Weather;
            BackColor = InitializeSky(match.Time);
        }

        private Color InitializeSky(string time)
        {
            int sky = int.Parse(time);
            int rnd = Hatsu.getRandomNum(10);
            if (sky < 18)
            {
                if (rnd < 2) return Color.SkyBlue;
                if (rnd < 4) return Color.LightSkyBlue;
                if (rnd < 6) return Color.DeepSkyBlue;
                if (rnd < 8) return Color.CornflowerBlue;
                if (rnd < 9) return Color.Gray;
                else return Color.DarkGray;
            }
            if (rnd < 4) return Color.MidnightBlue;
            if (rnd < 7) return Color.Navy;
            else return Color.SteelBlue;
        }



        

        //this method is the one that gets called every time the clock or the ball is clicked
        //and based on the text written under the clock it will decide to stop or play the timer
        private void UpdateGameState()
        {
            //Color green = Color.FromArgb(0, 192, 0);

            if (lGameState.Text == "Kick Off")
            {
                match.GameMoment = 1;
                //match.HasStarted = true;
                matchTimer.Enabled = true;
                lGameState.Text = match.GetGameMoment();
                pScore.BackColor = GREEN;
            }
            else if (lGameState.Text == "Resume")
            {
                lGameState.Text = match.GetGameMoment();
                matchTimer.Enabled = true;
                pScore.BackColor = GREEN;
            }
            else if (lGameState.Text == "Half Time")
            {
                match.GameMoment = 2;
                matchTimer.Enabled = true;
                lGameState.Text = match.GetGameMoment();
                pScore.BackColor = GREEN;
            }
            else if (lGameState.Text == "End of Regular Time")
            {
                matchTimer.Enabled = true;
                lGameState.Text = match.GetGameMoment();
                pScore.BackColor = GREEN;
            }
            else if (lGameState.Text == "End of Extra Time")
            {
                matchTimer.Enabled = true;
                lGameState.Text = match.GetGameMoment();
                pScore.BackColor = GREEN;
            }
            
            else if (lGameState.Text == "First Half" || lGameState.Text == "Second Half" || 
                lGameState.Text == "Extra Time" || lGameState.Text == "Penalties")
            {
                matchTimer.Enabled = false;
                lGameState.Text = "Resume";
                pScore.BackColor = RED;
            }
            else if (lGameState.Text == "End of the Match") Dispose();
        }

        private void MatchTimer_Tick(object sender, EventArgs e)
        {
            if (match.GameMoment != 5) //first we check if we are not having penalty shootouts
            {
                if (counter == 10) //every 10 ticks we get a game minute
                {
                    if (match.Minute == 45 && match.GameMoment == 1)
                    {
                        lGameState.Text = "Half Time";
                        matchTimer.Enabled = false;
                        pScore.BackColor = RED;
                        RestartPress();
                    }
                    else if (match.Minute == 90 && match.GameMoment == 2 && isExtraTime && IsMatchTied())
                    {
                        match.GameMoment = 3;
                        lGameState.Text = "End of Regular Time";
                        matchTimer.Enabled = false;
                        pScore.BackColor = RED;
                        RestartPress();
                    }
                    else if (match.Minute == 105 && match.GameMoment == 3)
                    {
                        match.GameMoment = 4;
                        lGameState.Text = "Resume";
                        matchTimer.Enabled = false;
                        pScore.BackColor = RED;
                        RestartPress();
                    }
                    else if (match.Minute == 120 && isPenalties && IsMatchTied())
                    {
                        match.GameMoment = 5;
                        homeTeam.PenAttemptsLeft = awayTeam.PenAttemptsLeft = 5;
                        lGameState.Text = "End of Extra Time";
                        lHomeEvents.Text += "\nPenalty Shoot-out\n";
                        lAwayEvents.Text += "\nPenalty Shoot-out\n";
                        lHomePenScore.Visible = lAwayPenScore.Visible = true;
                        matchTimer.Enabled = false;
                        pScore.BackColor = RED;
                        RestartPress();
                    }
                    else if (match.Minute < 90)
                    {
                        match.Minute += 1;
                        UpdateMatchTime();
                    }
                    else if (match.Minute < 120 && (match.GameMoment == 3 || match.GameMoment == 4))
                    {
                        match.Minute += 1;
                        UpdateMatchTime();
                    }
                    else
                    {
                        lGameState.Text = "End of the Match";
                        matchTimer.Enabled = false;
                        pScore.BackColor = RED;
                    }
                    counter = 0;
                    GetLance();
                }
                else
                {
                    counter++;
                    GetLance();
                }
            }
            else //penalties
            {
                if (counter == 100)
                {
                    if (homeTeam.PenAttemptsLeft == awayTeam.PenAttemptsLeft)
                        homeTeam.GetPenalty();
                    else awayTeam.GetPenalty();

                    if (homeTeam.PenScore + homeTeam.PenAttemptsLeft < awayTeam.PenScore || 
                        awayTeam.PenScore + awayTeam.PenAttemptsLeft < homeTeam.PenScore)
                        {
                            lGameState.Text = "End of the Match";
                            matchTimer.Enabled = false;
                        }
                        if (homeTeam.PenScore == awayTeam.PenScore && 
                        homeTeam.PenAttemptsLeft == 0 && awayTeam.PenAttemptsLeft == 0)
                        homeTeam.PenAttemptsLeft = awayTeam.PenAttemptsLeft = 1;
                        counter = 0;
                }
                else
                {
                    counter++;
                }
            }
        }

        private bool IsMatchTied()
        {
            if (homeTeam.GoalsScored.Count == awayTeam.GoalsScored.Count) return true;
            return false;
        }

        private void GetLance()
        {
            randomPlay = Hatsu.getRandomNum(90);
            if (randomPlay > 30) // timer moves and nothing happens
            {
                int attackPower = Hatsu.getRandomNum(5);
                if (randomPlay <= 60) //home attack
                {
                    if (homePress + attackPower > 99)
                    {
                        homePress = 99;
                    }
                    else
                    {
                        homePress += attackPower;
                    }
                    isHomeAttacking = true;
                    awayPress = 100 - homePress;
                }
                else //away attack
                {
                    if (awayPress + attackPower > 99)
                    {
                        awayPress = 99;
                    }
                    else
                    {
                        awayPress += attackPower;
                    }
                    homePress = 100 - awayPress;
                    isHomeAttacking = false;
                }
                UpdatePress();
                goalTarget = Hatsu.getRandomNum(1, 31);
                randomPlay = Hatsu.getRandomNum(1, 11);

                //here we check if someone scored a goal
                if (goalTarget % randomPlay == 0)
                {
                    int goalChance;
                    if (isHomeAttacking)
                    {
                        goalChance = homePress + (goalTarget) + randomPlay * 2;
                        if (goalChance >= 99 && goalChance <= 101)
                        {
                            homeTeam.ScoreGoal(match.Minute);
                            RestartPress();
                        }
                    }
                    else
                    {
                        goalChance = awayPress + (goalTarget) + randomPlay * 2;
                        if (goalChance >= 99 && goalChance <= 101)
                        {
                            awayTeam.ScoreGoal(match.Minute);
                            RestartPress();
                        }
                    }
                }
            }
        }

        private void RestartPress()
        {
            homePress = awayPress = 50;
            UpdatePress();
        }

        private void cbHomeStats_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeStatsPanels(homeTeam.PlayerPanels, cbHomeStats.SelectedIndex);
        }

        private void cbAwayStats_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeStatsPanels(awayTeam.PlayerPanels, cbAwayStats.SelectedIndex);
        }


        private void ChangeStatsPanels(IList<PlayerPanel> playerPanels, int index)
        {
            if (index == 0)
            {
                foreach (PlayerPanel playerPanel in playerPanels)
                    playerPanel.ChangeInfo(playerPanel.player.GetPosSide());
            }
            else
            {
                string statType = Hatsu.matchStats[index];
                foreach (PlayerPanel playerPanel in playerPanels)
                {
                    string finalStat = "" + playerPanel.player.Stats.getStatByName(statType);
                    if (statType.Equals("Condition"))
                        finalStat += "%";
                    playerPanel.ChangeInfo(finalStat);
                }
            }
        }

       
   

        private void CallHomeTactics(object sender, EventArgs e)
        {
            TacticsFrame tacticsFrame = new TacticsFrame(homeTeam, match);
            if (match.HasStarted)
            {
                Hide();
                tacticsFrame.ShowDialog();
                UpdateTeamComponents(homeTeam, true);
                Show();
            }
            else
            {
                Hide();
                tacticsFrame.ShowDialog();
                if (!homeTeam.Coach.IsReady)
                    Dispose();
                else
                {
                    Show();
                    UpdateTeamComponents(homeTeam, true);
                    
                }
            }
        }

        private void CallAwayTactics(object sender, EventArgs e)
        {
            TacticsFrame tacticsFrame = new TacticsFrame(awayTeam, match);
            if (match.HasStarted)
            {
                Hide();
                tacticsFrame.ShowDialog();
                UpdateTeamComponents(homeTeam, true);
                Show();
            }
            else
            {
                Hide();
                tacticsFrame.ShowDialog();
                if (!awayTeam.Coach.IsReady)
                    Dispose();
                else
                { 
                    Show();
                    UpdateTeamComponents(awayTeam, false);
                }
            }
        }

       

        private void updateMatchStats()
        {
            string statType;
            lMatchStats.Text = "";
            for (int i = 4; i < Hatsu.matchStats.Length; i++)
            {
                /*
                if (Hatsu.matchStats[i].Equals("Condition")) continue;
                if (Hatsu.matchStats[i].Equals("Rating")) continue; 
                if (Hatsu.matchStats[i].Equals("Goals")) continue;
                if (Hatsu.matchStats[i].Equals("Position")) continue;
                */
                statType = Hatsu.matchStats[i];
                lMatchStats.Text += "" + homeTeam.GetUpdatedStats(statType) + " - " +
                    Hatsu.matchStatsNames[i] + " - " + awayTeam.GetUpdatedStats(statType) + "\n";
                
            }
        }


        private void UpdatePress()
        {
            pHomePress.Width = pressSize * homePress / 100;
        }

        private void UpdateMatchTime()
        {
            lTime.Text = match.GetMatchMinute();
        }

        private void PScore_MouseEnter(object sender, EventArgs e)
        {
            if (pScore.BackColor == GREEN) pScore.BackColor = DARK_GREEN;
            else if (pScore.BackColor == RED) pScore.BackColor = DARK_RED;
        }

        private void PScore_MouseLeave(object sender, EventArgs e)
        {
            if (pScore.BackColor == DARK_GREEN) pScore.BackColor = GREEN;
            else if (pScore.BackColor == DARK_RED) pScore.BackColor = RED;
        }
        
        private void PScore_Click(object sender, EventArgs e)
        {
                UpdateGameState();
        }


        private void BtnMatchOverview_Click(object sender, EventArgs e)
        {
            if (currentTab != 2)
            {
                currentTab = 2;
                HideEverything();
                pMatchInfo.Visible = pHomeEvents.Visible = pAwayEvents.Visible = true;
            }
        }

        private void btnMatchStats_Click(object sender, EventArgs e)
        {
            if (currentTab != 0)
            {
                currentTab = 0;
                HideEverything();
                updateMatchStats();
                pHomeStats.Visible = pMatchStats.Visible = pAwayStats.Visible = true;
            }
        }


        private void btnReport_Click(object sender, EventArgs e)
        {
            if (currentTab != 4)
            {
                currentTab = 4;
                HideEverything();
                pMatchReport.Visible = true;
            }
        }

        private void btnPitchView_Click(object sender, EventArgs e)
        {
            if (currentTab != 1)
            {
                currentTab = 1;
                HideEverything();
                pPitchView.Visible = lPitchHomeNames.Visible = lPitchAwayNames.Visible = true;
                
            }
        }


        private void HideEverything()
        {
            pMatchReport.Visible =  pHomeEvents.Visible = pAwayEvents.Visible = pHomeStats.Visible = 
                pAwayStats.Visible = pMatchInfo.Visible = pMatchStats.Visible = pPitchView.Visible = 
                lPitchAwayNames.Visible = lPitchHomeNames.Visible = false;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
    }
}
