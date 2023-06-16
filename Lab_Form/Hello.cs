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
    public partial class Hello : Form
    {
        public Hello()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, 我是"+textBox1.Text+ 
                ",\n英文名字是" + textBox2.Text + 
                ",\n性別是" + textBox3.Text + 
                ",\n星座是" + textBox4.Text+ "\n很高興認識你");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi, 我是" + textBox1.Text +
                           ",\n英文名字是" + textBox2.Text +
                           ",\n性別是" + textBox3.Text +
                           ",\n星座是" + textBox4.Text + "\n很高興認識你");
        }

        private void Hello_Load(object sender, EventArgs e)
        {

        }
      

    }
}
