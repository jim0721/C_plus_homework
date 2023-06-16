using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Frm_M28_進階方法 : Form
    {
        public Frm_M28_進階方法()
        {
            InitializeComponent();
        }

        void Swap(ref int A ,ref int B)
        {
            int T = A;
            A = B;
            B = T;
        }

        void Swap(ref string A , ref string B)
        {
            string T = A;
            A = B;
            B = T;
        }

        void Swap(ref Point A , ref Point B)
        {
            Point T = A;
            A = B;
            B = T;
        }

        void GenericSwap<Tt>(ref Tt A , ref Tt B)
        {
            Tt T = A;
            A= B;
            B= T; 
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int a = 100, b = 200;
            MessageBox.Show("a: " + a + " , b: " + b);
            Swap(ref a, ref b);
            MessageBox.Show("a: " + a + " , b: " + b);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = "aaa", b = "bbb";
            MessageBox.Show("a: " + a + " , b: " + b);
            Swap(ref a, ref b);
            MessageBox.Show("a: " + a + " , b: " + b);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Point a = new Point(100,100),b = new Point(200,200);
            MessageBox.Show("a: " + a + " , b: " + b);
            Swap(ref a, ref b);
            MessageBox.Show("a: " + a + " , b: " + b);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int ia = 100, ib = 200;
            GenericSwap<int>(ref ia, ref ib);
            MessageBox.Show("a: " + ia + " , b: " + ib);

            string sa = "aaa", sb = "bbb";
            GenericSwap<string>(ref sa, ref sb);
            MessageBox.Show("a: " + sa + " , b: " + sb);

        }
    }
}
