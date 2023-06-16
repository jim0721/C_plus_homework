using Lab_Form;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass mc =  new MyClass();
            mc.Method04();

            Console.Write("請輸入姓名: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello C# ! " + name);

            Program pro = new Program();
            pro.Method01();

            Console.ReadKey();
        }

        void Method01()
        {
            Console.Write("Method01");
        }

    }
}
