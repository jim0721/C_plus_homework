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
    public partial class Frm_M19_struct : Form
    {
        public Frm_M19_struct()
        {
            InitializeComponent();
        }

        string EmployeeResult = "員工\n------------------\n";
        int count = 0;
        int totalAge = 0;

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            //Employee emp;
            //emp.Name = txtEmployeeName.Text;
            //emp.Age = int.Parse(txtEmployeeAge.Text);

            //Employee empP = new Employee();
            //empP.Name = txtEmployeeName.Text;
            //empP.Age = int.Parse(txtEmployeeAge.Text);

            //Employee emp =
            //    new Employee(txtEmployeeName.Text
            //    , int.Parse(txtEmployeeAge.Text));

            int age = 0;
            bool isNum = int.TryParse(txtEmployeeAge.Text, out age);

            if(isNum)
            {
                Employee emp = new Employee(txtEmployeeName.Text, age);
                count++;
                totalAge += emp.Age;
                EmployeeResult += emp.Name + " , " + emp.Age;
            }
            else
            {
                MessageBox.Show("好好打字");
                //txtEmployeeAge.Text = "";
                txtEmployeeAge.Clear();
                txtEmployeeAge.Focus();
            }
        }

        private void btnShowEmployee_Click(object sender, EventArgs e)
        {
            labShowEmployee.Text = EmployeeResult  +
                "\n-----------\n員工人數: " + count + " , 平均年齡: " + totalAge / count;
        }

        private void labShowEmployee_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtEmployeeName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmployeeAge_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
