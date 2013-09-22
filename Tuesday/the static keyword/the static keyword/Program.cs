using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_static_keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            //class1 x = new class1();
            //x.age = 24;
            //x.SayHello();
            //class1.num1 = 17;
            //class1.Greeting();

            Console.WriteLine("hello");
            Console.WriteLine( Math.Pow(2,3)   );

        }
    }

    class class1
    {
        public static int num1;
        public int age;

        public void SayHello()
        {
            age = 11;
            num1 = 18;
        }
        public static void Greeting()
        {
            num1 = 20;
          
        }
    }

    static class class2
    {
       static int x;
    
    }
}
