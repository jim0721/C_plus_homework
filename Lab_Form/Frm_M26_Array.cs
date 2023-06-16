using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace Lab_Form
{
    public partial class Frm_M26_Array : Form
    {
        public Frm_M26_Array()
        {
            InitializeComponent();
        }

        private void btnArray_Click(object sender, EventArgs e)
        {
            //int[] arr = new int[3];
            //arr[0] = 1;
            //arr[1] = 2;
            //arr[2] = 3;
            ////arr[3] = 4;

            //int[] arr = new int[3] { 1, 2, 3};

            int[] arr = { 1, 2, 3 };

            string result = "";
            for(int i =0; i < arr.Length; i++)
            {
                result +=  arr[i] + "\n";
            }

            MessageBox.Show(result);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int[,] arr = new int[3, 2];
            //arr[0, 0] = 1;
            //arr[0, 1] = 2;
            //arr[1, 0] = 3;
            //arr[1, 1] = 4;
            //arr[2, 0] = 5;
            //arr[2, 1] = 6;

            int[,] arr = new int[3, 2]
            {
                { 1 , 2 }  ,
                { 3 , 4 }  ,
                { 5 , 6 }
            };

            string result = "";
            for(int i = 0 ; i<arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    //result += "arr[" + i + " , " + j + "] ->" + arr[i, j] + "\n";
                    result += $"arr[{i} , {j}] ->{arr[i,j]}\n";
                }
            }

            MessageBox.Show(result);
        }

        private void btnCreateArray_Click(object sender, EventArgs e)
        {
            string[] myArr =  CreateArray(20);
            string result = "";

            foreach (string item in myArr)
            {
                result += item + "\n";
            }

            //int i = 0;
            //while( i < myArr.Length)
            //{
            //    result += myArr[i] + "\n";
            //    i++;
            //}
            //for (int i = 0; i < myArr.Length; i++)
            //{
            //    result += myArr[i] + "\n";
            //}
            MessageBox.Show(result);
        }

        string[] CreateArray (int Length)
        {
            string[] arr = new string[Length];
            for(int i = 0; i<arr.Length; i++)
            {
                arr[i] = i.ToString();
            }
            return arr;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Member[] members = new Member[2];
            members[0] = new Member();
            members[0].Name = "John";
            members[0].Age = 40;
            members[1] = new Member();
            members[1].Name = "Cena";
            members[1].Age = 50;

            string result = "";
            foreach( Member item in members)
            {
                result += $"Name: {item.Name} , Age: {item.Age}\n";
            }
            MessageBox.Show(result);
        }
    }
}
