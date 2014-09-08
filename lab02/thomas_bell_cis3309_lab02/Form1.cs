using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thomas_bell_cis3309_lab02{
    public partial class Form1 : Form{
        public Form1(){
            InitializeComponent();
        }

        private int options() {
            int optionsTotal = 0;
            if (chkYoga.Checked) { optionsTotal += 10; }
            if (chkKarate.Checked) { optionsTotal += 30; }
            if (chkPersonalTrainer.Checked) { optionsTotal += 30; }
            return optionsTotal;
        }

        private int membershipType(){
            int fee;
            if (rbAdult.Checked){
                fee = 40;
            }else if (rbChild.Checked){
                fee = 20;
            }else if (rbStudent.Checked){
                fee = 25;
            }else{
                fee = 30;
            }
            return fee;
        }

        private int membershipLength(){
            int length;
            Int32.TryParse(txtMembershipLength.Text, out length);
            txtMembershipLength.Text = Convert.ToString(length);
            return length;
        }

        private int monthlyFee(){
            int monthly;
            monthly = membershipType() + options();
            return monthly;
        }

        private int total(){
            int total;
            total = monthlyFee() * membershipLength();
            return total;
        }

        private void btnCalculate_Click(object sender, EventArgs e){
            txtMonthlyFee.Text = monthlyFee().ToString("C2");
            txtTotal.Text = total().ToString("C2");
        }

        private void btnExit_Click(object sender, EventArgs e){
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e){
            txtMembershipLength.Clear();
            txtMonthlyFee.Clear();
            txtTotal.Clear();
            chkKarate.Checked = false;
            chkPersonalTrainer.Checked = false;
            chkYoga.Checked = false;
            rbAdult.Checked = true;
        }
    }
}
