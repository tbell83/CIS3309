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
    public partial class frmManageCustomers : Form
    {
        
        string customerFirstName;
        string customerLastName;
        string customerAddress;
        string customerPhoneNumber;
        string customerID;
        int CID;
        string input;
        MovieRentalSystem rentalSystem = new MovieRentalSystem();

        public frmManageCustomers()
        {
            InitializeComponent();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(txtFirstName.Text) != true)
                {
                    customerFirstName = txtFirstName.Text;
                }
            }
            catch
            {
                MessageBox.Show("Need a valid first name!");
                txtFirstName.Clear();
            }


            try
            {
                if (string.IsNullOrWhiteSpace(txtLastName.Text) != true)
                {
                    customerLastName = txtLastName.Text;
                }
            }
            catch
            {
                MessageBox.Show("Need a valid first name!");
                txtLastName.Clear();
            }


            try
            {
                if (string.IsNullOrWhiteSpace(txtAddress.Text) != true)
                {
                    customerAddress = txtAddress.Text;
                }
            }
            catch
            {
                MessageBox.Show("Need a valid first name!");
                txtAddress.Clear();
            }


            try
            {
                if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text) != true)
                {
                    customerPhoneNumber = txtPhoneNumber.Text;
                }
            }
            catch
            {
                MessageBox.Show("Need a valid first name!");
                txtPhoneNumber.Clear();
            }


            try
            {
                CID = int.Parse(txtCustomerID.Text); // Test if the length is 4 digits or not
                if (customerID.ToString().Length == 4)
                {
                    customerID = customerID.ToString();
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

            input = customerFirstName + ";" + customerLastName + ";" + customerAddress + ";" + customerPhoneNumber + ";" + customerID;
            rentalSystem.addCustomer(input);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}