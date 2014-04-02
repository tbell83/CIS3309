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

namespace Movie_Rental_System
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
            try
            {
                if (string.IsNullOrWhiteSpace(txtFirstName.Text))
                {
                    txtFirstName.BackColor.Equals(Color.Red);
                    MessageBox.Show("Please input first name.");
                }
                else
                    firstName = txtFirstName.Text;

            }
            catch
            {
                MessageBox.Show("Please input first name.");
                txtFirstName.BackColor.Equals(Color.Red);
            }

            try
            {
                if (string.IsNullOrWhiteSpace(txtFirstName.Text))
                {
                    txtFirstName.BackColor.Equals(Color.Red);
                    MessageBox.Show("Please input last name.");
                }
                else
                    lastName = txtLastName.Text;
            }
            catch
            {
                MessageBox.Show("Please input last name.");
            }


            try
            {
                if (string.IsNullOrWhiteSpace(txtFirstName.Text))
                {
                    txtFirstName.BackColor.Equals(Color.Red);
                    MessageBox.Show("Please input address.");
                }
                else
                    address = txtAddress.Text;
            }
            catch
            {
                MessageBox.Show("Please input address.");
            }


            try
            {
                if (string.IsNullOrWhiteSpace(txtFirstName.Text))
                {
                    txtFirstName.BackColor.Equals(Color.Red);
                    MessageBox.Show("Please input phone number.");
                }
                else
                    phoneNumber = txtPhoneNumber.Text;
            }
            catch
            {
                MessageBox.Show("Please input phone number.");
            }


            try
            {
                if (string.IsNullOrWhiteSpace(txtFirstName.Text))
                {
                    txtFirstName.BackColor.Equals(Color.Red);
                    MessageBox.Show("Please input balance.");
                }
                else
                    balance = txtBalance.Text;
            }
            catch
            {
                MessageBox.Show("Please input balance.");
            }



            try
            {
                dateOfBirth = txtDoB.Text;
            }
            catch
            {
                MessageBox.Show("Please input date of birth.");
            }


            try
            {
                customerID = int.Parse(txtCustomerID.Text); // Test if the length is 4 digits or not
                if (customerID.ToString().Length == 4)
                {
                    CID = customerID.ToString();
                }
                else
                {
                    MessageBox.Show("Please enter 4 digits");
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
                //   if(rentalSystem.findCustomer(txtCustomerID.Text) = false);
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

        }



        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

