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
    public partial class Frm_M12 : Form
    {
        public Frm_M12()
        {
            InitializeComponent();
        }

        int count = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            //count = count + 2;

            count += 2;

            labCount.Text = "Count: " + count;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int result = ++count;  

            // count += 1;
            // result = count;

            labCount.Text = "Count: " + count;

            labResult.Text = "Result: " + result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int result = count++;

            // result = count;
            // count += 1;

            labCount.Text = "Count: " + count;
            labResult.Text = "Result: " + result;
        }

        private void btnConst_Click(object sender, EventArgs e)
        {
            const double pi = 3.14;

            //pi = 3.14;

            //pi = 3.59;

        }

        private void btnLocalVar_Click(object sender, EventArgs e)
        {
            int a = 100;

            if (true)
            {
                
                int x = 10;
                a = x;
                c = 100;
            }

            //x
        }

        void MethodLocalVar()
        {
            //a 
            //    x
            c = 2000;
        }

        public int c = 1000;

        private void btnClassVar_Click(object sender, EventArgs e)
        {
            c = 2000;
        }
        InstanceAndStatic ins = new InstanceAndStatic();
        private void InstanceVar_Click(object sender, EventArgs e)
        {            
            ins.InstanceVar++; // ins.InstanceVar = ins.InstanceVar + 1;
            labInstanceCount.Text = "instance Count: " + ins.InstanceVar;
        }

        private void StaticVar_Click(object sender, EventArgs e)
        {
            InstanceAndStatic.StaticVar++;  // InstanceAndStatic.StaticVar = InstanceAndStatic.StaticVar +1;
            labStaticCount.Text = "static Count: " + InstanceAndStatic.StaticVar;
        }

        private void btnOpenHelloForm_Click(object sender, EventArgs e)
        {
            Frm_M02_HelloForm frm = new Frm_M02_HelloForm();
            frm.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void labCount_Click(object sender, EventArgs e)
        {

        }

        private void labResult_Click(object sender, EventArgs e)
        {

        }

        private void labInstanceCount_Click(object sender, EventArgs e)
        {

        }

        private void labStaticCount_Click(object sender, EventArgs e)
        {

        }
    }
}
