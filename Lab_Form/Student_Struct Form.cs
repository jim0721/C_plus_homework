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
    public partial class Student_Struct_Form : Form
    {
        String name;
        Int32 chinese;
        Int32 english;
        Int32 math;

        public Student_Struct_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            chinese = Int32.Parse(textBox2.Text);
            english = Int32.Parse(textBox3.Text);
            math = Int32.Parse(textBox4.Text); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text="姓名:"+ name +
                            "\n國文:" + chinese +
                            "\n英文:" + english +
                            "\n數學:" + math;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox2.Text="最高的成績為: " + Math.Max(chinese, Math.Max(english, math))+
            "\n最低的成績為: " + Math.Min(chinese, Math.Min(english, math));
            Console.WriteLine(english+chinese);
        }       
    }
}
