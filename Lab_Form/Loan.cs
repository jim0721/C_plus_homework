using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Loan : Form
    {
        double month_price = 0;
        double total = 0;
        public Loan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double loanprice = Int32.Parse(textBox1.Text);
            double year = Int32.Parse(textBox2.Text);
            double rate = Int32.Parse(textBox3.Text);
            double payment = Int32.Parse(textBox4.Text);
            double amount = loanprice - payment;
            month_price = amount * Math.Pow((1 + (rate / 1200)), (year * 12)) * ((rate / 1200) / (Math.Pow((1 + (rate / 1200)), (year * 12)) - 1));
            MessageBox.Show("月付額: " + Math.Round(month_price));
        }
        private void button2_Click(object sender, EventArgs e)
        {
            double loanprice = Int32.Parse(textBox1.Text);
            double year = Int32.Parse(textBox2.Text);
            double rate = Int32.Parse(textBox3.Text);
            double payment = Int32.Parse(textBox4.Text);
            double amount = loanprice - payment;
            month_price = amount * Math.Pow((1 + (rate / 1200)), (year * 12)) * ((rate / 1200) / (Math.Pow((1 + (rate / 1200)), (year * 12)) - 1));
            total = (month_price * year * 12);
            MessageBox.Show("總金額: " + Math.Round(total));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double loanprice = Int32.Parse(textBox1.Text);
            double year = Int32.Parse(textBox2.Text);
            double rate = Int32.Parse(textBox3.Text);
            double payment = Int32.Parse(textBox4.Text);
            double amount = loanprice - payment;
            month_price = amount * Math.Pow((1 + (rate / 1200)), (year * 12)) * ((rate / 1200) / (Math.Pow((1 + (rate / 1200)), (year * 12)) - 1));
            total = (month_price * year * 12);
            Loan_Report report= new Loan_Report();
            report.textBox1.Text = textBox1.Text;
            report.textBox2.Text = textBox2.Text;  
            report.textBox3.Text = textBox3.Text;
            report.textBox4.Text = Math.Round(month_price).ToString();
            report.textBox5.Text = Math.Round(total).ToString(); ;
            report.ShowDialog();
        }

        private void Loan_Load(object sender, EventArgs e)
        {
            double loanprice = Int32.Parse(textBox1.Text);
            double year = Int32.Parse(textBox2.Text);
            double rate = Int32.Parse(textBox3.Text);
            double payment = Int32.Parse(textBox4.Text);
            double amount = loanprice - payment;
            month_price = amount * Math.Pow((1 + (rate / 1200)), (year * 12)) * ((rate / 1200) / (Math.Pow((1 + (rate / 1200)), (year * 12)) - 1));
            total = (month_price * year * 12);
        }
    }
}
