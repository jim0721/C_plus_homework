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
    public partial class Frm_M16_參數 : Form
    {
        public Frm_M16_參數()
        {
            InitializeComponent();
        }

        private void btnByValue_Click(object sender, EventArgs e)
        {
            int A = 999;
            ByValue(A);
            MessageBox.Show(A.ToString());
        }

        void ByValue(int X)
        {
            X = 100;
        }

        private void btnByReference_Click(object sender, EventArgs e)
        {
            Member mem = new Member
            {
                Name = "短今",
                Age = 40
            };

            MessageBox.Show("Name: " + mem.Name + " , Age: " + mem.Age);

            ByRefercence(mem);

            MessageBox.Show("Name: " + mem.Name + " , Age: " + mem.Age) ;
        }

        void ByRefercence(Member member)
        {
            member.Age = 22;
        }

        private void byRef_Click(object sender, EventArgs e)
        {
            int A = 999;
            ByRef(ref A);
            MessageBox.Show(A.ToString());
        }

        void ByRef(ref int X)
        {
            X = 100;
        }

        private void btnByOut_Click(object sender, EventArgs e)
        {
            int A = 0;
            ByOut(out A);
            MessageBox.Show(A.ToString());
        }

        void ByOut(out int X)
        {
            //X += 100;
            X = 100;
        }

        private void btnParams_Click(object sender, EventArgs e)
        {
            string totalChi =  TotalScore("國文", 100, 60, 80, 90);
            MessageBox.Show(totalChi);
            string totalMath =  TotalScore("數學", 60, 70);
            MessageBox.Show(totalMath);
        }

        string TotalScore(string Subject , params int[] Scores)
        {
            int Total = 0;
            for(int i = 0; i < Scores.Length;i++)
            {
                Total += Scores[i];
            }
            return Subject + " 的總成績為 " + Total + " 分";
        }

    }
}
