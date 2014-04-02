using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Rental_System
{
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmCustomerOptions customerOptions = new frmCustomerOptions();
            customerOptions.ShowDialog();
        }

        private void btnMovie_Click(object sender, EventArgs e)
        {
            frmMovieOptions movieOptions = new frmMovieOptions();
            movieOptions.ShowDialog();
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            frmRentalOptions rentalOptions = new frmRentalOptions();
            rentalOptions.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
