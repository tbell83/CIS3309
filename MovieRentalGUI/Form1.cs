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
using File_Reader;

namespace MovieRentalGUI
{
    public partial class Form1 : Form
    {
        MovieRentalSystem MRS = new MovieRentalSystem();

        public Form1()
        {
            FileReader read = new FileReader();

            InitializeComponent();
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
                    string output = MRS.listCustomer(item);
                    listBox1.Items.Add(output);
                }
            }
            else
            {
                List<int> cust_results = MRS.findCustomer(query);
                List<int> movi_results = MRS.findMovie(query);
                foreach (int item in cust_results)
                {
                    string output = MRS.listCustomer(item);
                    listBox1.Items.Add(output);
                }
                foreach (int item in movi_results)
                {
                    string output = MRS.listMovie(item);
                    listBox1.Items.Add(output);
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
