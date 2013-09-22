using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_static_ctor
{
    class Program
    {
        static void Main(string[] args)
        {
            class1 x = new class1();
            class1 y = new class1();
            //Console.WriteLine(class1.rate);
        }
    }
    class class1
    {
        public static int rate;
        //public class1()
        //{
        //    Console.WriteLine("instance ctor");
        //}
        static class1()
        {
            Console.WriteLine("static ctor");
        }
    }
}
