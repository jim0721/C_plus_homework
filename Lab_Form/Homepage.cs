using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Homepage : Form
    {
        Form current;
        Boolean flag = false;
        public Homepage()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (flag) {
                current.Close();
                panel3.Controls.Remove(current);
            }
            current = new Hello() { TopLevel = false, TopMost = true };
            this.panel3.Controls.Add(current);
            current.Show();
            flag = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                current.Close();
                panel3.Controls.Remove(current);
            }
            current = new Loan() { TopLevel = false, TopMost = true };
            this.panel3.Controls.Add(current);
            current.Show();
            flag = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                current.Close();
                panel3.Controls.Remove(current);
            }
            current = new My_Clac() { TopLevel = false, TopMost = true };
            this.panel3.Controls.Add(current);
            current.Show();
            flag = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                current.Close();
                panel3.Controls.Remove(current);
            }
            current = new Picture_Viewer() { TopLevel = false, TopMost = true };
            this.panel3.Controls.Add(current);
            current.Show();
            flag = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                current.Close();
                panel3.Controls.Remove(current);
            }
            current = new POS() { TopLevel = false, TopMost = true };
            this.panel3.Controls.Add(current);
            current.Show();
            flag = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                current.Close();
                panel3.Controls.Remove(current);
            }
            current = new Student_Struct_Form() { TopLevel = false, TopMost = true };
            this.panel3.Controls.Add(current);
            current.Show();
            flag = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                current.Close();
                panel3.Controls.Remove(current);
            }
            current = new Students_Grade() { TopLevel = false, TopMost = true };
            this.panel3.Controls.Add(current);
            current.Show();
            flag = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                current.Close();
                panel3.Controls.Remove(current);
            }
            current = new 考試_Guess() { TopLevel = false, TopMost = true };
            this.panel3.Controls.Add(current);
            current.Show();
            flag = true;
        }
    }
}
