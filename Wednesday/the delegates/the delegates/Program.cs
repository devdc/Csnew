using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_delegates
{
    public delegate void delHandler(int a,int b);

    class Program
    {
        static void Main(string[] args)
        {
            delHandler d1 = new delHandler(Add);
            //d1(3, 5);
            //Add(3, 5);

            class1 x = new class1();
            delHandler d2 = new delHandler(x.Subtract);
            //d2(2, 6);
            //x.Subtract(2, 6);

            delHandler d3 = d1 + d2;
            d3(20, 4);

          

        }

        static void Add(int a, int b)
        { 
            Console.WriteLine(a+b); 
        }
    }

   

    class class1
    {
               
       
        public void Subtract(int x, int y)
        {
            Console.WriteLine(x-y); 
        }
    }
}
