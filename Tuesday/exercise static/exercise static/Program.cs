using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_static
{
    class Program
    {
       

        static void Main(string[] args)
        {
 class1 a = new class1();
        class1 b = new class1();
        class1 c = new class1();

            string choice;
            do
            {
                Console.Write("please enter a-a.Add, b-b.Add, c-c.Add, e-exit: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "a":
                        a.Add();
                        break;
                    case "b":
                        b.Add();
                        break;
                    case "c":
                        c.Add();
                        break;
                }

            } while (choice != "e");
        }
    }
    class class1
    {
        public int x;
        public static int y;
        public void Add()
        {
            Console.WriteLine("x={0} y={1}", ++x, ++y);
        }
    }
}
