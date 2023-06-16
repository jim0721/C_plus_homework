using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_Form
{
    public partial class My_Clac : Form
    {
        public My_Clac()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double Num1 = Double.Parse(textBox1.Text);
            Double Num2 = Double.Parse(textBox2.Text);
            Double sum = Num1 + Num2;
            textBox3.Text = sum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Double Num1 = Double.Parse(textBox1.Text);
            Double Num2 = Double.Parse(textBox2.Text);
            Double sum = Num1 - Num2;
            textBox3.Text = sum.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Double Num1 = Double.Parse(textBox1.Text);
            Double Num2 = Double.Parse(textBox2.Text);
            Double sum = Num1 * Num2;
            textBox3.Text = sum.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox2.Text=="0"){
                textBox3.Text = "∞";
            } else {
                Double Num1 = Double.Parse(textBox1.Text);
                Double Num2 = Double.Parse(textBox2.Text);
                Double sum = Num1 / Num2;
                textBox3.Text = sum.ToString();
            }  

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
