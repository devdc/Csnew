using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises_conditions_and_iterators
{
    class Program
    {
        static void Main(string[] args)
        {

           #region inputouput
            Console.Write("please enter first number: ");
            double d1 = double.Parse(Console.ReadLine());
            Console.Write("please enter second number: ");
            double d2 = double.Parse(Console.ReadLine());

            Console.WriteLine(d1 > d2 ? d1 : d2);

            //#endregion
            //#region condition
            //if (d1 > d2)
            //{
            //    Console.WriteLine(d1);
            //}
            //else if (d2 > d1)
            //{
            //    Console.WriteLine(d2);
            //}
            //else
            //{
            //    Console.WriteLine("equal");
            //} 
            #endregion

            for (int i = 10; i <= 99; i++)
            {
                if (i%7==0 || i%10==7 || i-i%10==70)
                {
                    Console.Write(i+" ");
                }
            }
            Console.WriteLine();

           
        }
    }
}
