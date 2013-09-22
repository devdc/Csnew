using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace more_about_ctors
{
    class Program
    {
        static void Main(string[] args)
        {
            class1 x = new class1();
            Console.WriteLine(x.age);
            Console.WriteLine(2*class1.PI);
        }
    }

    class class1
    {
        public readonly int age=11;
        public const double PI = 3.1415267;

        public class1()
        {
            age = 23;  
        }
        public void Init()
        {
           // age = 20;
        }
    }
}
