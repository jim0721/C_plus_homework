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
    public partial class Frm_M24_loop : Form
    {
        public Frm_M24_loop()
        {
            InitializeComponent();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int i = 0;
            string result = "";

            while (i < 10)
            {
                if(i > 5)
                {
                    MessageBox.Show("Break; " + i );
                    break;
                }

                result += i++ + "\n";
                //i++;
            }

            MessageBox.Show(result);
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            int i = 0;
            string result = "";

            do
            {
                if(i % 2 == 0)
                {
                    i++;
                    continue;
                }
                result += i + "\n";
                i++;
            } while (i < 10);

            MessageBox.Show(result);
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            string result = "";

            //for(int i = 0; i<10; i++)
            //{
            //    result += i + "\n";
            //}

            for(int i = 0 , x = 50 , y = 100; y - 2* i > x ; i++ , y-- , x+= 2)
            {
                result += "i: " + i + " , x: " + x + " , y: " + y + "\n";
            }

            MessageBox.Show(result);
        }

        private void btnForeach_Click(object sender, EventArgs e)
        {
            foreach(Control item  in this.Controls)
            {
                //if(item.GetType() != typeof(Button))
                //{
                //    continue;
                //}

                if( !(item is Button))
                {
                    continue;
                }

                item.BackColor = Color.Black;
                item.ForeColor = Color.Pink;
                item.Left -= 10;
                item.Top -= 10;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
