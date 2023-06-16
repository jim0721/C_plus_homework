using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab_Form
{
    public partial class Students_Grade : Form
    {
        Int32 count = 0;
        ArrayList rows = new ArrayList();
        public Students_Grade()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("請輸入姓名");
            }
            else if (textBox2.Text == "") {
                MessageBox.Show("請輸入國文");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("請輸入英文");
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("請輸入數學");
            }
            count++;
            button3.Enabled = true;
            string name = textBox1.Text;
            string chinese = textBox2.Text;
            string english = textBox3.Text;
            string math = textBox4.Text;
            Double avg = (Int32.Parse(chinese) + Int32.Parse(english) + Int32.Parse(math)) / 3;
            Int32 max = Math.Max(Int32.Parse(chinese), Math.Max(Int32.Parse(english), Int32.Parse(math)));
            Int32 min = Math.Min(Int32.Parse(chinese), Math.Min(Int32.Parse(english), Int32.Parse(math)));
            string max_sub = "";
            string min_sub = "";
            if (max == Int32.Parse(chinese)) {
                 max_sub = "國文";
            } else if (max == Int32.Parse(english)) {
                 max_sub = "英文";
            } else if (max == Int32.Parse(math)) { 
                 max_sub = "數學";
            }

            if (min == Int32.Parse(chinese))
            {
                 min_sub = "國文";
            }
            else if (min == Int32.Parse(english))
            {
                 min_sub = "英文";
            }
            else if (min == Int32.Parse(math))
            {
                 min_sub = "數學";
            }

            richTextBox1.Text += name + "\t" + chinese + "\t"+ english + "\t"
                + math + "\t" + (Int32.Parse(chinese)+ Int32.Parse(english) + Int32.Parse(math))+ "\t"  
                + avg + "\t" + min_sub + min + "\t" + max_sub + max + "\n";

            ArrayList record = new ArrayList();
            record.Add(name);
            record.Add(Int32.Parse(chinese));
            record.Add(Int32.Parse(english));
            record.Add(Int32.Parse(math));
            record.Add(Int32.Parse(chinese) + Int32.Parse(english) + Int32.Parse(math));
            record.Add(avg);
            record.Add(min_sub+min);
            record.Add(max_sub+max);
            rows.Add(record);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            count++;
            button3.Enabled = true;
            Random rnd = new Random();
            Int32 chinese = rnd.Next(100);
            Int32 english = rnd.Next(100);
            Int32 math = rnd.Next(100);
            Double avg = (chinese + english + math) / 3;
            Int32 max = Math.Max(chinese, Math.Max(english, math));
            Int32 min = Math.Min(chinese, Math.Min(english, math));
            string max_sub = "";
            string min_sub = "";
            if (max == chinese)
            {
                max_sub = "國文";
            }
            else if (max == english)
            {
                max_sub = "英文";
            }
            else if (max == math)
            {
                max_sub = "數學";
            }

            if (min == chinese)
            {
                min_sub = "國文";
            }
            else if (min == english)
            {
                min_sub = "英文";
            }
            else if (min == math)
            {
                min_sub = "數學";
            }
            richTextBox1.Text += count + "\t" + chinese + "\t" + english + "\t"
                + math + "\t" + (chinese + english + math) + "\t"
                + avg + "\t" + min_sub + min + "\t" + max_sub + max + "\n";

            ArrayList record = new ArrayList();
            record.Add(count.ToString());
            record.Add(chinese);
            record.Add(english);
            record.Add(math);
            record.Add(chinese + english + math);
            record.Add(avg);
            record.Add(min_sub + min);
            record.Add(max_sub + max);
            rows.Add(record);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Int32 total_chinese = 0;
            Int32 total_english = 0;
            Int32 total_math = 0;
            Int32 max_chinese = 0;
            Int32 max_english = 0;
            Int32 max_math = 0;
            Int32 min_chinese = 200;
            Int32 min_english = 200;
            Int32 min_math = 200;

            richTextBox2.Text = "";
            foreach (ArrayList row in rows) {
                //Console.WriteLine(row[6]);
                total_chinese += (int)row[1];
                max_chinese = Math.Max(max_chinese, (int)row[1]);
                min_chinese = Math.Min(min_chinese, (int)row[1]);
                total_english += (int)row[2];
                max_english = Math.Max(max_english, (int)row[2]);
                min_english = Math.Min(min_english, (int)row[2]);
                total_math += (int)row[3];
                max_math = Math.Max(max_math, (int)row[3]);
                min_math = Math.Min(min_math, (int)row[3]);
            }
            richTextBox2.Text += "總分\t" + total_chinese + "\t" + total_english + "\t"
                + total_math + "\n" + "平均\t" 
                + ((double)total_chinese / rows.Count).ToString("#0.0") + "\t"
                + ((double)total_english / rows.Count).ToString("#0.0") + "\t" 
                + ((double)total_math / rows.Count).ToString("#0.0") + "\n" 
                + "最高分\t" + max_chinese + "\t"
                + max_english + "\t" + max_math + "\n" + "最低分\t" + min_chinese + "\t" 
                + min_english + "\t" + min_math;

            //Console.WriteLine(rows.Count);
        }
       

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            count = 0;
            button3.Enabled = false;
            rows.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            button3.Enabled = true;
            for (int i = 0; i<20;i++) {
                count++;
                Int32 chinese = rnd.Next(100);
                Int32 english = rnd.Next(100);
                Int32 math = rnd.Next(100);
                Double avg = (chinese + english + math) / 3;
                Int32 max = Math.Max(chinese, Math.Max(english, math));
                Int32 min = Math.Min(chinese, Math.Min(english, math));
                string max_sub = "";
                string min_sub = "";
                if (max == chinese)
                {
                    max_sub = "國文";
                }
                else if (max == english)
                {
                    max_sub = "英文";
                }
                else if (max == math)
                {
                    max_sub = "數學";
                }

                if (min == chinese)
                {
                    min_sub = "國文";
                }
                else if (min == english)
                {
                    min_sub = "英文";
                }
                else if (min == math)
                {
                    min_sub = "數學";
                }
                richTextBox1.Text += count + "\t" + chinese + "\t" + english + "\t"
                    + math + "\t" + (chinese + english + math) + "\t"
                    + avg + "\t" + min_sub + min + "\t" + max_sub + max + "\n";

                ArrayList record = new ArrayList();
                record.Add(count.ToString());
                record.Add(chinese);
                record.Add(english);
                record.Add(math);
                record.Add(chinese + english + math);
                record.Add(avg);
                record.Add(min_sub + min);
                record.Add(max_sub + max);
                rows.Add(record);
            }
        }
    }
}
