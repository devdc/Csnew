using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_functions
{
    class Program
    {
        static void Main(string[] args)
        {
            
//            Trace.WriteLine("helloooooooooooooooooo");

//#if DEBUG
//            Console.WriteLine("hello programmer");
//#else

//            Console.WriteLine("hello freindly user");
//#endif

            //for (int i = 0; i < 300; i++)
            //{
            //    Console.WriteLine("i="+i);
            //}
            int a, b, c;
            Console.Write("please enter first number: ");
            a = int.Parse(Console.ReadLine());
           // Debug.Assert(a < 12);
            Console.Write("please enter second number: ");
            b = int.Parse(Console.ReadLine());
            //c = MultiSwitch(a, b);
            //Console.WriteLine("byvalue: c={0} a={1} b={2}",c,a,b);

            c = MultiSwitch(ref a,ref b);
            Console.WriteLine("byReference c={0} a={1} b={2}", c, a, b);
        }
      
        static int MultiSwitch(int num1, int num2)
        {
            num1 = num2 * 2;
            num2 = num1 * 2;
            return num1 * num2;
        }
        static int MultiSwitch(ref int num1,ref int num2)
        {
            num1 = num2 * 2;
            num2 = num1 * 2;
            return num1 * num2;
        }
    }
}
