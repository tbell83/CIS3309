using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollProgram
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblHourlyRate_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHourlyRate.Text = "";
            txtHoursWorked.Text = "";
            txtOutput.Text = "";
        }

        private void btnCalculatePay_Click(object sender, EventArgs e)
        {
            double state_income, federal_income, social_security, medicare, net, pay;
            try
            {
                pay = Convert.ToDouble(txtHourlyRate.Text) * Convert.ToDouble(txtHoursWorked.Text);
            }
            catch(System.FormatException)
            {
                txtHourlyRate.Text = "Try Again";
                return;
            }
            state_income = pay * .035;
            federal_income = pay * .15;
            social_security = pay * .062;
            medicare = pay * .029;
            net = pay - (state_income + federal_income + social_security + medicare);

            txtOutput.Text = "Gross Pay: " + pay.ToString("c2") + "\r\nState Income Tax: " + state_income.ToString("c2") + "\r\nFederal Income Tax: " + federal_income.ToString("c2") + "\r\nSocial Security: " + social_security.ToString("c2") + "\r\nMedicare: " + medicare.ToString("c2") + "\r\nNet Pay: " + net.ToString("c2");
        }

        private void txtHourlyRate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
