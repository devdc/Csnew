using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_functions
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 20, b = 30, c;
            //c = Add(a,ref b);
            //Console.WriteLine("c={0} a={1} b={2}",c,a,b);

            //int d=11;
            //init(out d);
            //Console.WriteLine("d="+d);

            //Console.WriteLine( Subtract(20,5) );
            //Console.WriteLine( Subtract(20));

            Console.WriteLine( Factorial(5));


            //num1,num2
            //num1=num2*2
            //num2=num1*2
            //num1*num2
        }

        static int Factorial(int i)
        {
            if (i>1)
            {
                return i * Factorial(--i);
            }
            return 1;
        }



        static int Subtract(int a, int b = 1)
        {
            return a - b;
        }

        static int Add(int a,int b)
        {
            return a + 5;
        }


        static void init(out int x)
        {
            x = 34;

        }
        static int Add(int x,ref int y)
        {
            x++;
            y--;
            if (x<y)
            {
                return x + 1;
            }
            return y + 3;
        }
    }
}
