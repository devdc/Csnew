using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager m = new Manager();
            m.Greeting();
        }
    }

   //abstract class Person
   // sealed class Person
    class Person
    {
        public int age { get; set; }
        public string firstName { get; set; }
        public virtual void Greeting()
        {
            Console.WriteLine("good morning "+firstName);
        }
    }
    class Manager : Person
    {
        public override void Greeting()
        {
            base.Greeting();
            Console.WriteLine("have a nice day");
        }
    }
}
