using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Frm_M34_ReadWrite : Form
    {
        public Frm_M34_ReadWrite()
        {
            InitializeComponent();
        }

        private void btnStreamReader_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("../../obj/read.txt", Encoding.UTF8);
            txtReadWrite.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void btnStringWriter_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("../writer.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            sw.Write(txtReadWrite.Text);
            sw.Close();
            fs.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 0;

            string result = "";
            while(x < 10)
            {
                result += x++ + "\n";
            }

            ShowResult(result);
        }

        void ShowResult(string result)
        {
            MessageBox.Show(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] arr = { 1, 2, 3 };
            string result = "";

            try
            {                
                for (int i = 0; i <= arr.Length; i++)
                {
                    if(i> 1)
                    {
                        throw new AggregateException("錯的呦");
                    }
                    result += arr[i] + "\n";
                }
            }
            catch(IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(AppDomainUnloadedException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ShowResult(result);
            }

          
        }

        private void txtReadWrite_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
