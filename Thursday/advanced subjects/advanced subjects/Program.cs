using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advanced_subjects
{
    class Program
    {
        static void Main(string[] args)
        {
            class1 x = new class1();
            
        }
    }


    partial class class1
    {
        public void a() { c(); }

        partial void c();


        partial void c()
        {
            Console.WriteLine(123);
        }

    }
}
