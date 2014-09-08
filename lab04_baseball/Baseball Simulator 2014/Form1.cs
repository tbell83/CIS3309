using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Baseball_Simulator_2014;
using System.Collections;

namespace Baseball_Simulator_2014{
    public partial class frmOuput : Form {
        public frmOuput() {
            InitializeComponent();
            baseballGame game = new baseballGame();
            int[,] outcome = game.Game();
            Label[,] labels = new Label[,] { { lblTeam00, lblTeam01, lblTeam02, lblTeam03, lblTeam04, lblTeam05, lblTeam06, lblTeam07, lblTeam08}, { lblTeam10, lblTeam11, lblTeam12, lblTeam13, lblTeam14, lblTeam15, lblTeam16, lblTeam17, lblTeam18 } };
            int finalA = 0;
            int finalB = 0;
            string teamA = "Yankees";
            string teamB = "Phillies";

            lblTeamA.Text = teamA;
            lblTeamB.Text = teamB;

            for (int inning = 0; inning < 9; inning++) {
                for (int team = 0; team < 2; team++) {
                    labels[team, inning].Text = outcome[team, inning].ToString();
                    if (team == 0)  {
                        finalA += outcome[team, inning];
                        lblTeam0F.Text= finalA.ToString();
                    } else {
                        finalB += outcome[team, inning];
                        lblTeam1F.Text = finalB.ToString();
                    }
                }
            }
        }
    }
}
