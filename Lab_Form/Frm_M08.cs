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
    public partial class Frm_M08 : Form
    {
        public Frm_M08()
        {
            InitializeComponent();
        }

        private void btnRegisterEvent_Click(object sender, EventArgs e)
        {
            //this.btnRegisterEvent.Click += new System.EventHandler(this.btnRegisterEvent_Click);
            btnRegister01.Click += new EventHandler(btnRegister01Click);
            btnRegister02.Click += BtnRegister02Click;

            int i = 0;
            //i += 2;
            i = i + 2;
        }

        private void BtnRegister02Click(object sender, EventArgs e)
        {
            MessageBox.Show("Register02");
        }

        private void btnRegister01Click(object sender, EventArgs e)
        {
            MessageBox.Show("Register01");
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            Payment pay;

            decimal Amount = decimal.Parse(txtAmount.Text);

            if(cmbDiscount.Text == "50%off")
            {
                pay = Discount50off;
            }
            else
            {
                pay = Discount20off;
            }

            decimal result =  pay(Amount);

            MessageBox.Show("折扣後金額: " + result);
        }

        delegate decimal Payment (decimal amount);

        decimal Discount50off(decimal amount)
        {
            return amount * 0.5m;
        }

        decimal Discount20off(decimal amount)
        {
            return amount * 0.8m;
        }

        private void btnSetProperty_Click(object sender, EventArgs e)
        {
            btnSetProperty.Text = "設定屬性";
            btnSetProperty.BackColor = Color.Black;
            btnSetProperty.ForeColor = Color.Pink;
        }

        private void btnGetProperty_Click(object sender, EventArgs e)
        {
            MessageBox.Show(btnSetProperty.Text);
        }

        private void btnCallMethod_Click(object sender, EventArgs e)
        {
            btnCallMethod.SetBounds(100, 100, 200, 200);
        }

        private void btnMessageBox_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("晚上要不要逛夜市?", "問你喔", 
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                MessageBox.Show("好咖");
            }
            else
            {
                MessageBox.Show("有夠歹揪");
            }

        }

        private void btnOpenHelloForm_Click(object sender, EventArgs e)
        {
            Frm_M02_HelloForm frm = new Frm_M02_HelloForm();
            DialogResult result = frm.ShowDialog();

            if(result == DialogResult.OK)
            {
                MessageBox.Show("IU 我 OK");
            }

        }

        private void btnFDD_Click(object sender, EventArgs e)
        {
            float f = 3.14f;

            double d = 3.14;

            decimal dec = 314m;
        }

        private void btnRegister01_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister02_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
