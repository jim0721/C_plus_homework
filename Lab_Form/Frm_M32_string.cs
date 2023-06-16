using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Frm_M32_string : Form
    {
        public Frm_M32_string()
        {
            InitializeComponent();
            labTime.Text = DateTime.Now.ToString();
        }

        private void btnString_Click(object sender, EventArgs e)
        {
            string str1 = "AAAAA";
            str1 = "BBBBB";

            string str2 = str1;
            str2 = "CCCCC";
            MessageBox.Show($"str1: {str1} , str2: {str2}");
        }

        private void btnStringBuilder_Click(object sender, EventArgs e)
        {
            StringBuilder sb1 = new StringBuilder();
            sb1.Append("AAAAA");

            StringBuilder sb2 = sb1;
            sb2.Append("BBBBBB");

            MessageBox.Show("sb1: " + sb1.ToString() + "\nsb2: " + sb2.ToString());
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            //string dir = "C:\\Users\\User\\Desktop\\Lab_Csharp\\images\\IU.jpg";
            string dir = @"C:\Users\User\Desktop\Lab_Csharp\images\IU.jpg";

            string result = "";
            result += Path.GetFullPath(dir)+"\n";
            result += Path.GetFileName(dir) + "\n";
            result += Path.GetExtension(dir) + "\n";
            result += Path.GetDirectoryName(dir);

            MessageBox.Show(result);
        }

        private void btnValid_Click(object sender, EventArgs e)
        {
            if (isStrongPassword(txtPassword.Text))
            {
                labPwValid.Text = "密碼強度高";
                timerPW.Enabled = false;
                labPwValid.BackColor = SystemColors.Control;
                labPwValid.ForeColor = SystemColors.ControlText;
            }
            else
            {
                labPwValid.Text = "密碼強度低";
                timerPW.Enabled = true;
            }

            if (isIdCorrect(txtID.Text))
            {
                labIdValid.Text = "正確";
            }
            else
            {
                labIdValid.Text = "錯誤";
            }

        }

        bool isStrongPassword(string Password)
        {
            return Regex.IsMatch(Password, @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,16}$");
        }
        bool isIdCorrect(string ID)
        {
            return Regex.IsMatch(ID, @"^[A-Z]{1}[1-2]{1}[0-9]{8}$");
        }

        bool flagPw = true;
        private void timerPW_Tick(object sender, EventArgs e)
        {
            if (flagPw)
            {
                labPwValid.BackColor = Color.Red;
                labPwValid.ForeColor = Color.Yellow;
            }
            else
            {
                labPwValid.BackColor = Color.Yellow;
                labPwValid.ForeColor = Color.Red;
            }
            flagPw = !flagPw;
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            labTime.Text = DateTime.Now.ToString();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (isStrongPassword(txtPassword.Text))
            {
                labPwValid.Text = "密碼強度高";
                timerPW.Enabled = false;
                labPwValid.BackColor = SystemColors.Control;
                labPwValid.ForeColor = SystemColors.ControlText;
            }
            else
            {
                labPwValid.Text = "密碼強度低";
                timerPW.Enabled = true;
            }
        }

        private void labIdValid_Click(object sender, EventArgs e)
        {

        }

        private void labPwValid_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void labTime_Click(object sender, EventArgs e)
        {

        }
    }
}
