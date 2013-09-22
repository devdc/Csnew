using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_delegate_anonym_method_Lambda
{
    delegate int delHandler(int a,int b);

    class Program
    {
        static void Main(string[] args)
        {
            delHandler d1 = Add;
            //Console.WriteLine(d1(3,4));

            delHandler d2 = delegate(int x, int y) {  return x + y; };
            //Console.WriteLine(d2(3,4));

            delHandler d3 = (x, y) => x + y;
            Console.WriteLine(d3(3,4));
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
