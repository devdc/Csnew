using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_functions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("first");
            //Greeting();
            //Console.WriteLine("last");
            Add(12, "dina");
            //Add(20);
            Add(name: "dina", age: 12);
           
        }

        static void Add(int age, string name="yona")
        {
            Console.WriteLine("hello "+name);
            Console.WriteLine(age + 3);
        }


        static void Greeting()
        {
            Console.WriteLine("hello");
            Console.WriteLine("hello again");
        }


    }
}
