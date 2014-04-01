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

namespace videoRentalSystem
{
    public partial class frmCustomerOptions : Form
    {
        MovieRentalSystem rentalSystem = new MovieRentalSystem();
        string firstName;
        string lastName;
        string address;
        string dateOfBirth;
        int customerID;
        string CID;
        string phoneNumber;
        string balance;


        public frmCustomerOptions()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            firstName = txtFirstName.Text;
            lastName = txtLastName.Text;
            address = txtAddress.Text;
            phoneNumber = txtPhoneNumber.Text;
            balance = txtBalance.Text;
            dateOfBirth = txtDoB.Text;


            try
            {
                customerID = int.Parse(txtCustomerID.Text); // Test if the length is 4 digits or not
                if (customerID.ToString().Length == 4)
                {
                    CID = customerID.ToString();
                }
                else
                {
                    MessageBox.Show("Please only enter 4 digits");
                    txtCustomerID.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid 4 digit pin");
                txtCustomerID.Clear();
            }




            try
            {
                //Read in the text file/database
                //See if duplicate ID exists
                //go to catch
            }
            catch
            {
                MessageBox.Show("No duplicate PIN Numbers.");
                txtCustomerID.Clear();
            }



            string input = (firstName + ";" + lastName + ";" + address + ";" + phoneNumber + ";" + balance + ";" + dateOfBirth + ";" + CID);
            rentalSystem.addCustomer(input);
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            string findID = txtCustomerID.Text;
            if (findID != null)
            {

            }
        }
    }
}

