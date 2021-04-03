using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace XokaFutebol
{
    public partial class introFrame : Form
    {
        ErrorProvider nameErrorProvider, teamErrorProvider;
        public IList<Obj.TeamInfo> teamList;
        int maxBench; //maxSubs;
        public introFrame()
        {
            InitializeComponent();
        }

        private void IntroForm_Load(object sender, EventArgs e)
        {
            FixGraphics();
            InitializeErrorProviders();
            InitializeTeamList();
            tbPlayerName.Text = Hatsu.getRandomName();
            cbSeasons.SelectedIndex = 0;
        }

        private void FixGraphics()
        {
            int offset = Width / 1000;
            int centerPoint = Width / 2 - pMainMenu.Width / 2;
            pMainMenu.Location = pNewGame.Location = new Point(centerPoint, Height * 3 / 7 - offset * 10);
            int centerLogo = Width / 2 - labelTitle.Width / 2;
            labelTitle.Location = new Point(centerLogo - offset * 5, Height / 12);
            picBola.Size = new Size(Width / 15, Height / 9);
            picBola.Location = new Point(Width * 9 / 14 - offset * 13 , Height / 6 + offset * 15);
        }

        private void InitializeTeamList()
        {
            teamList = LoadTeams();
            foreach (var n in teamList)
            {
                cbPlayerTeam.Items.Add(n.name);
            }
            cbGameMode.SelectedIndex = 0;
        }

        private IList<Obj.TeamInfo> LoadTeams()
        {
            string filepath = "..\\Data\\teams.json";
            string json;
            using (StreamReader file = File.OpenText(filepath))
            {
                json = file.ReadToEnd();
            }
            IList<Obj.TeamInfo> teams = JsonConvert.DeserializeObject<List<Obj.TeamInfo>>(json);
            filepath = "..\\Data\\players.json";
            using (StreamReader file = File.OpenText(filepath))
            {
                json = file.ReadToEnd();
            }
            JObject playerList = JObject.Parse(json);
            for (int i = 0; i < 3; i++)
            { 
                IList<JToken> players = playerList[teams[i].name].Children().ToList();
                IList<Obj.Player> newPlayers = new List<Obj.Player>();
                foreach (JToken player in players)
                {
                    Obj.Player newPlayer = player.ToObject<Obj.Player>();
                    newPlayers.Add(newPlayer);
                }
                teams[i].roster = newPlayers;
            }
            filepath = "..\\Data\\coaches.json";
            using (StreamReader file = File.OpenText(filepath))
            {
                json = file.ReadToEnd();
            }
            IList<Obj.Coach> coaches = JsonConvert.DeserializeObject<List<Obj.Coach>>(json);
            for (int i = 0; i < 3; i++)
            {
                coaches[i].TeamInfo = teams[i];
                teams[i].coach = coaches[i];
            }
            return teams;
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnNewGame_Click(object sender, EventArgs e)
        {
            pMainMenu.Visible = false;
            pNewGame.Visible = true;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            string playerName = this.tbPlayerName.Text;
            if (playerName.Length == 0)
            {
                nameErrorProvider.SetError(this.tbPlayerName, "Please Choose a Name!");
            }
            else if (cbPlayerTeam.Text.Length == 0)
            {
                nameErrorProvider.SetError(this.cbPlayerTeam, "Please Choose a Team!");
            }
            else
            {
                if (cbGameMode.SelectedIndex == 0)
                {
                    maxBench = 11;
                    //maxSubs = 11;
                }
                else if (cbGameMode.SelectedIndex == 1)
                {
                    maxBench = 7;
                    //maxSubs = 3;
                }
                int playerTeamIndex = cbPlayerTeam.SelectedIndex;
                Obj.TeamInfo playerTeamInfo = teamList[playerTeamIndex];
                int teamIndex = Hatsu.getRandomNum(3);
                while (playerTeamIndex == teamIndex) { teamIndex = Hatsu.getRandomNum(3); }
                Obj.TeamInfo compTeamInfo = teamList[teamIndex];
                Obj.Team homeTeam = new Obj.Team(playerTeamInfo, true, maxBench);
                Obj.Team awayTeam = new Obj.Team(compTeamInfo, false, maxBench);
                Obj.Match match = new Obj.Match(homeTeam, awayTeam);

                Hide();
                if (match.homeTeam.Coach.IsHuman)
                {

                    TacticsFrame matchSquadFrame = new TacticsFrame(homeTeam, match);
                    matchSquadFrame.ShowDialog();
                }
                else
                {
                    homeTeam.Coach.IsReady = true;
                    homeTeam.UpdateSquads(homeTeam.TeamOrder);
                }
                
                if (match.awayTeam.Coach.IsHuman)
                {
                    TacticsFrame matchSquadFrame = new TacticsFrame(awayTeam, match);
                    matchSquadFrame.ShowDialog();
                }
                else
                {
                    awayTeam.Coach.IsReady = true;
                    awayTeam.UpdateSquads(awayTeam.TeamOrder);
                }

                if (homeTeam.Coach.IsReady && awayTeam.Coach.IsReady)
                {
                    MatchFrame matchFrame = new MatchFrame(match);
                    matchFrame.ShowDialog();
                }
                Show();
            }
        }

        

        private void BtnBack_Click(object sender, EventArgs e)
        {
            pMainMenu.Visible = true;
            pNewGame.Visible = false;
        }

        private void BtnLoadGame_Click(object sender, EventArgs e)
        {
            //MatchSquadFrame matchSquadFrame = new MatchSquadFrame();
            
            //Hide();
            //matchSquadFrame.ShowDialog();
            //Show();
        }

        private void InitializeErrorProviders()
        {
            nameErrorProvider = new System.Windows.Forms.ErrorProvider();
            nameErrorProvider.SetIconAlignment(this.tbPlayerName, ErrorIconAlignment.MiddleRight);
            nameErrorProvider.SetIconPadding(this.tbPlayerName, 2);
            nameErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.BlinkIfDifferentError;
            teamErrorProvider = new System.Windows.Forms.ErrorProvider();
            teamErrorProvider.SetIconAlignment(this.cbPlayerTeam, ErrorIconAlignment.MiddleRight);
            teamErrorProvider.SetIconPadding(this.cbPlayerTeam, 2);
            teamErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.BlinkIfDifferentError;
        }
    }
}
