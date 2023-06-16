using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Lab_Form
{
    public partial class 考試_Guess : Form
    {
        static Random rnd = new Random();
        Int32 ans = rnd.Next(100);
        Int32 max = 100;
        Int32 min = 0;
        Boolean flag = true;

        public 考試_Guess()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flag = true;
            while (flag) {
                string guess = Interaction.InputBox("Please enter a number: ", "Guess", "", 500, 500);
                if (guess== "")
                {
                    //MessageBox.Show("請輸入介於 " + min + "和" + max + "之間");
                    flag = false;
                }
                else {
                    Int32 number = Int32.Parse(guess);
                    if (number > max || number < min)
                    {
                        MessageBox.Show("請輸入介於 " + min + "和" + max + "之間");
                    }
                    else
                    {
                        if (number == ans)
                        {
                            MessageBox.Show("Congradulation! You got " + ans);
                            flag = false;
                        }
                        else if (number <= ans)
                        {
                            min = number;
                            label1.Text = "Too Small\nPlease enter number between " + min + " and " + max + ".";
                        }
                        else if (number >= ans)
                        {
                            max = number;
                            label1.Text = "Too Large\nPlease enter number between " + min + " and " + max + ".";
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ans: "+ ans);
            min = 0;
            max = 100;
            ans = rnd.Next(100);
        } 
    }
}
