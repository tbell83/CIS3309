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
    public partial class Form1 : Form
    {
        string test_movie1 = "Blade Runner;R;Action/SciFi;0;In a world with something, unicron at the end";
        string test_movie2 = "Terminator;R;Action;9999;Quirky robot galavanting through time.";
        string test_movie3 = "Terminator II: Judgement Day;R;Action;9999;Quirky robot galavanting through time, having a ball.";
        string test_customer1 = "Bob;Hope;10 Main Street;9993336666;0.00;1983/10/28;9988";
        string test_customer2 = "Bob;Barker;10 Road Street;888666444;0.00;1980/1/1;9938";
        string test_customer3 = "Tina;Roberts;82 Street Lane;8884442222;57.00;1950/1/31;9977";

        MovieRentalSystem MRS = new MovieRentalSystem();

        public Form1()
        {
            InitializeComponent();
            MRS.addMovie(test_movie1);
            MRS.addMovie(test_movie2);
            MRS.addMovie(test_movie3);
            MRS.addCustomer(test_customer1);
            MRS.addCustomer(test_customer2);
            MRS.addCustomer(test_customer3);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = txtSearchBox.Text;
            listBox1.Items.Clear();
            if (comboBox1.Text == "Movie")
            {
                List<int> results = MRS.findMovie(query);
                foreach (int item in results)
                {
                    string output = MRS.listMovie(item);
                    listBox1.Items.Add(output);
                }
            }
            else if (comboBox1.Text == "Customer")
            {
                List<int> results = MRS.findCustomer(query);
                foreach (int item in results)
                {
                    listBox1.Items.Add(MRS.listCustomer(item));
                }
            }
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {

        }

        private void btnMovies_Click(object sender, EventArgs e)
        {

        }

    }
}
