using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace payroll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            double hours = double.Parse(txtww.Text);
            double hourlyrate = double.Parse(txthr.Text);

            double grosspay = hours * hourlyrate;

            double sss = grosspay * 0.20;
            double philhealth = grosspay * 0.10;
            double pagibig = grosspay * 0.05;
            double tax = grosspay * 0.25;
            double totaldeduction = sss + philhealth + pagibig + tax;

            double netpay = grosspay - totaldeduction;

            txtgross.Text = grosspay.ToString("₱0.00");
            txtsss.Text= sss.ToString("₱0.00");
            txttax.Text = tax.ToString("₱0.00");
            txtpagibig.Text = pagibig.ToString("₱0.00");
            txtphil.Text = philhealth.ToString("₱0.00");
            txttotal.Text = totaldeduction.ToString("₱0.00");
            txtnet.Text = netpay.ToString("₱0.00");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
