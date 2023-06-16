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
    public partial class Frm_M21 : Form
    {
        public Frm_M21()
        {
            InitializeComponent();
        }
        bool flag = true;
        private void btnReverse_Click(object sender, EventArgs e)
        {            
            if(flag)
            {
                btnReverse.BackColor = Color.RoyalBlue;
                //flag = false;
            }
            else
            {
                btnReverse.BackColor = Color.Green;
                //flag = true;
            }
            flag = !flag;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnReverse.BackColor = flag ? Color.RoyalBlue : Color.Green;
            flag =!flag;
        }

        private void btnIf_Click(object sender, EventArgs e)
        {
            int i = 0;
            if(i > 0)
            {
                MessageBox.Show("true");
            }

        }

        private void btnIfElse_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (i > 0)
            {
                MessageBox.Show("true");
            }
            else
            {
                MessageBox.Show("false");
            }

        }

        private void btnIfElseIf_Click(object sender, EventArgs e)
        {
            // 90~100 -> A
            // 80~89 -> B
            // 70~79 -> C
            // 60~69 -> D
            // ~59 -> E

            //int score = int.Parse( txtScore.Text);

            int score = 0;

            bool isScoreNum = int.TryParse(txtScore.Text , out score);

            if (isScoreNum)
            {
                if (score >= 90 && score <= 100)
                    labGrade.Text = "A級";
                else if (score >= 80)
                    labGrade.Text = "B級";
                else if (score >= 70)
                    labGrade.Text = "C級";
                else if (score >= 60)
                    labGrade.Text = "D級";       
                else
                    labGrade.Text = "E級";

    
                //switch (score)
                //{
                //    case 100:
                //    case 99:
                //    case 98:
                //        labGrade.Text = "A級";
                //        break;
                //}
            }
            else
            {
                MessageBox.Show("請輸入數字");
                txtScore.Clear();
            }
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("晚上要不要逛夜市?", "問你喔",
               MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            switch (result)
            {
                case DialogResult.Yes:
                    MessageBox.Show("好咖");
                    break;
                case DialogResult.No:
                    MessageBox.Show("有夠歹揪");
                    break;
                default:
                    MessageBox.Show("啊是要還是不要啦");
                    break;
            }


            //if (result == DialogResult.Yes)
            //{
            //    MessageBox.Show("好咖");
            //}
            //else
            //{
            //    MessageBox.Show("有夠歹揪");
            //}
        }

        private void txtScore_TextChanged(object sender, EventArgs e)
        {

        }

        private void labGrade_Click(object sender, EventArgs e)
        {

        }
    }
}
