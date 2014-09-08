using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game_class;

namespace Game_Gui{
    public partial class Form1 : Form{
        Game game = new Game();
        public Form1(){
            InitializeComponent();
            reset();
        }

        private void button1_Click(object sender, EventArgs e){
            int guess;
            bool inputValidation = Int32.TryParse(txtGuess.Text, out guess);
            if (inputValidation){
                int status = game.takeTurn(guess);
                lblTurn.Text = game.getTurn().ToString();
                if (status == 0){
                    lblOutput.Text = "You Win!";
                    btnSend.Enabled = false;
                }else if(status == 1){
                    lblOutput.Text = "Too High";
                    txtGuess.Clear();
                }
                else if (status == 2)
                {
                    lblOutput.Text = "Too Low";
                    txtGuess.Clear();
                }
                else if (status == 3) {
                    lblOutput.Text = "You Lose.";
                    btnSend.Enabled = false;
                }else if(status == 4){
                    lblOutput.Text = "Let's do try and follow directions.";
                }
            }else{
                MessageBox.Show("Enter a number between\n1 and 100 in the box");
            } 
        }

        private void btnReset_Click(object sender, EventArgs e){
            reset();
        }

        private void reset(){
            txtGuess.Focus(); 
            game.newGame();
            lblTurn.Text = game.getTurn().ToString();
            lblOutput.Text = "I'm thinking of a number \n between 1 and 100...";
            txtGuess.Clear();
            btnSend.Enabled = true;
            lblLosses.Text = game.getRecord()[1].ToString();
            lblWins.Text = game.getRecord()[0].ToString();
        }
    }
}