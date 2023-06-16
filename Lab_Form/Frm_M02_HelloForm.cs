using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Frm_M02_HelloForm : Form
    {
        public Frm_M02_HelloForm()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            // 註解
            //todo 等等要做messagebox
            string name = txtName.Text;
            System.Windows.Forms.MessageBox.Show("Hello, " + name);
        }

        private void btnStaticCount_Click(object sender, EventArgs e)
        {
            MessageBox.Show(InstanceAndStatic.StaticVar.ToString());
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }

        private void Frm_M02_HelloForm_Load(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
