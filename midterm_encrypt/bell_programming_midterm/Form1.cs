using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bell_programming_midterm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int shift = Convert.ToInt16(numericUpDown1.Value);
            string toEncrypt = txtDecrypted.Text;
            cipher cipher = new cipher();
            txtEncrypted.Text = cipher.encrypt(toEncrypt, shift);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            int shift = Convert.ToInt16(numericUpDown1.Value);
            string toEncrypt = txtEncrypted.Text;
            cipher cipher = new cipher();
            txtDecrypted.Text = cipher.decrypt(toEncrypt, shift);
        }
    }
}
