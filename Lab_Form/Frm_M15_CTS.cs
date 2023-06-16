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
    public partial class Frm_M15_CTS : Form
    {
        public Frm_M15_CTS()
        {
            InitializeComponent();
        }

        private void btnValueType_Click(object sender, EventArgs e)
        {
            int A = 100;

            int B = A;

            MessageBox.Show("A: " + A + " , B: " + B);

            A = 200;

            MessageBox.Show("A: " + A + " , B: " + B);
        }

        private void btnReferenceType_Click(object sender, EventArgs e)
        {
            TextBox tb = txtReferenceType;
            tb.Text = "Refernce Type";
            tb.BackColor = Color.Black;
            tb.ForeColor = Color.Pink;
        }

        private void txtReferenceType_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
