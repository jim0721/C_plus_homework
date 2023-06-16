using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_Form
{
    public partial class POS : Form
    {
        Int32 sum = 0; //總金額
        Boolean initFlag = true;
        Int32 num_beer = 0;
        Int32 num_tequila = 0;
        Int32 num_whisky = 0;
        Int32 num_wine = 0;

        public POS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (initFlag) {
                listBox1.Items.Clear();
                initFlag = false;
            }
            num_beer++;
            //listBox1.Items.Add("啤酒Beer x" + num_beer + ",共NT$ "+ (num_beer*120) +" 元");
            for (int n = listBox1.Items.Count - 1; n >= 0; --n)
            {
                string removelistitem = "Beer";
                if (listBox1.Items[n].ToString().Contains(removelistitem))
                {
                    listBox1.Items.RemoveAt(n);
                }
            }
            listBox1.Items.Insert(0, "啤酒Beer x" + num_beer + ",共NT$ " + (num_beer * 120) + " 元");
            sum = (num_beer * 120) + (num_tequila * 180) + (num_whisky * 350) + (num_wine * 320);
            textBox1.Text = "NT$ " + sum;
;        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (initFlag)
            {
                listBox1.Items.Clear();
                initFlag = false;
            }
            num_tequila++;
            for (int n = listBox1.Items.Count - 1; n >= 0; --n)
            {
                string removelistitem = "Tequila";
                if (listBox1.Items[n].ToString().Contains(removelistitem))
                {
                    listBox1.Items.RemoveAt(n);
                }
            }
            if (listBox1.Items.Count < 2)
            {
                listBox1.Items.Add("龍舌蘭Tequila x" + num_tequila + ",共NT$ " + (num_tequila * 180) + " 元");
            }
            else {
                listBox1.Items.Insert(1, "龍舌蘭Tequila x" + num_tequila + ",共NT$ " + (num_tequila * 180) + " 元");
            }
            sum = (num_beer * 120) + (num_tequila * 180) + (num_whisky * 350) + (num_wine * 320);
            textBox1.Text = "NT$ " + sum;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (initFlag)
            {
                listBox1.Items.Clear();
                initFlag = false;
            }
            num_whisky++;
            for (int n = listBox1.Items.Count - 1; n >= 0; --n)
            {
                string removelistitem = "Whisky";
            if (listBox1.Items[n].ToString().Contains(removelistitem))
            {
                listBox1.Items.RemoveAt(n);
            }
          }
            if (listBox1.Items.Count< 3)
            {
                listBox1.Items.Add("威士忌Whisky x" + num_whisky + ",共NT$ " + (num_whisky* 350) + " 元");
            }
            else {
                listBox1.Items.Insert(2, "威士忌Whisky x" + num_whisky + ",共NT$ " + (num_whisky* 350) + " 元");
            }
            sum = (num_beer * 120) + (num_tequila * 180) + (num_whisky * 350) + (num_wine * 320);
            textBox1.Text = "NT$ " + sum;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (initFlag)
            {
                listBox1.Items.Clear();
                initFlag = false;
            }
            num_wine++;
            for (int n = listBox1.Items.Count - 1; n >= 0; --n)
            {
                string removelistitem = "Wine";
                if (listBox1.Items[n].ToString().Contains(removelistitem))
                {
                    listBox1.Items.RemoveAt(n);
                }
            }
            if (listBox1.Items.Count < 4)
            {
                listBox1.Items.Add("紅酒Wine x" + num_wine + ",共NT$ " + (num_wine * 320) + " 元");
            }
            else
            {
                listBox1.Items.Insert(3, "紅酒Wine x" + num_wine + ",共NT$ " + (num_wine * 320) + " 元");
            }
            sum = (num_beer * 120) + (num_tequila * 180) + (num_whisky * 350) + (num_wine * 320);
            textBox1.Text = "NT$ " + sum;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("總金額:NT$" + sum);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("總金額:NT$" + sum + "\n折扣後金額:NT$" + sum*0.9);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sum = 0;
            num_beer = 0;
            num_tequila = 0;
            num_wine = 0;
            num_whisky = 0;
            textBox1.Text = "NT$ " + sum;
            listBox1.Items.Clear();
            listBox1.Items.Add("尚未點餐");
            initFlag = true;
        }
    }
}
