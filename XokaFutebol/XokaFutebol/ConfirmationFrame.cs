using System;
using System.Windows.Forms;

namespace XokaFutebol
{
    public partial class ConfirmationFrame : Form
    {
        Obj.Team team;
        Obj.Substitution substitution;
        int subsLeft;
        string playerName;
        
        public ConfirmationFrame(Obj.Substitution substitution, Obj.Team team, int subsLeft, string playerName)
        {
            InitializeComponent();
            this.team = team;
            this.substitution = substitution;
            this.subsLeft = subsLeft;
            this.playerName = playerName;
        }

        private void Confirmation_Load(object sender, EventArgs e)
        {
            if (substitution == null && playerName.Equals(String.Empty))
            {
                lSubs.Text = "No more substitutions can be made";
                btnCancel.Visible = false;
                btnConfirm.Left = Width / 2 - btnConfirm.Width / 2;
            }
            else if (!playerName.Equals(String.Empty))
            {
                lSubs.Text = String.Format("{0} has already been subbed out of this game", playerName);
                btnCancel.Visible = false;
                btnConfirm.Left = Width / 2 - btnConfirm.Width / 2;
            }
            else
            {
                lSubs.Text = substitution.PlayerOut.Nickname + " (out) - "
                + substitution.PlayerIn.Nickname + " (in)\n\n" + subsLeft + " substitutions remaining";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (substitution != null && playerName == String.Empty) team.MakeSubstitution(substitution);
            Dispose();
        }
    }
}
