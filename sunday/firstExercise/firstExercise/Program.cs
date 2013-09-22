using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname, lname;
            Console.Write("please enter your name: ");
            fname = Console.ReadLine();
            Console.Write("please enter your family name: ");
            lname = Console.ReadLine();
            Console.WriteLine("hello {0} {1}",fname,lname);

        }
    }
}
