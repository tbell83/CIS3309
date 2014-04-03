using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Movie_Rental_System;

namespace MovieRentalGUI
{
    public partial class frmManageMovies : Form
    {
        string movieTitle;
        string movieGenre;
        string movieRating;
        string movieDescription;
        MovieRentalSystem rentalSystem = new MovieRentalSystem();

        bool isCheckedGenre;
        bool isCheckedRating;

        string input;


        public frmManageMovies()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radAction_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(txtTitle.Text) != true)
                {
                    movieTitle = txtTitle.Text;
                }
            }
            catch
            {
                MessageBox.Show("Need a valid first name!");
                txtTitle.Clear();
            }


            if (isCheckedGenre = radAction.Checked)
                movieGenre = radAction.Text;

            if (isCheckedGenre = radAdventure.Checked)
                movieGenre = radAdventure.Text;

            if (isCheckedGenre = radComedy.Checked)
                movieGenre = radComedy.Text;

            if (isCheckedGenre = radFantasy.Checked)
                movieGenre = radFantasy.Text;

            if (isCheckedGenre = radHorror.Checked)
                movieGenre = radHorror.Text;

            if (isCheckedGenre = radKids.Checked)
                movieGenre = radKids.Text;

            if (isCheckedGenre = radSciFi.Checked)
                movieGenre = radSciFi.Text;

            if (isCheckedRating = radG.Checked)
                movieRating = radG.Text;

            if (isCheckedRating = radPG.Checked)
                movieRating = radPG.Text;

            if (isCheckedRating = radPGTT.Checked)
                movieRating = radPGTT.Text;

            if (isCheckedRating = radR.Checked)
                movieRating = radR.Text;

            try
            {
                if (string.IsNullOrWhiteSpace(rtbDescription.Text) != true)
                {
                    movieDescription = rtbDescription.Text;
                }
            }

            catch
            {
                MessageBox.Show("Need a description of the movie!");
            }

            input = movieTitle + ";" + movieGenre + ";" + movieRating + ";" + movieDescription;

            rentalSystem.addMovie(input);
        }
    }
}
