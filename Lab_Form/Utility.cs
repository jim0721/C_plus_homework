using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class MyClass
    {
        void Method01()
        {
            MessageBox.Show("Method01");
        }
        private void Method02()
        {
            MessageBox.Show("Method02 private");
        }
        internal void Method03()
        {
            MessageBox.Show("Method03 internal");
        }
        public void Method04()
        {
            MessageBox.Show("Method04 public");
        }
        public void Method05()
        {
            Method01();
            Method02();
        }
    }

    public class Member
    {
        public string Name;
        public int Age = 20;
    }

    public class InstanceAndStatic
    {
        public int InstanceVar = 0;
        public static int StaticVar = 0;
    }

    public enum UserRole :byte
    {
        Admin = 2,
        User , 
        Guest
    }

    public struct Employee
    {
        //public string Name;
        //public int Age;
        public string Name { get; set; }
        public int Age { get; set; }

        public Employee(string EmployeeName 
            , int EmployeeAge)
        {
            Name = EmployeeName  ;
            Age = EmployeeAge;
        }
    }

    public struct Product
    {
        public string Name;
        public decimal UnitPrice;
    }
}
