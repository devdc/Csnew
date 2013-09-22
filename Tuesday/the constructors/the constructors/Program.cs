using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            //Console.WriteLine(x);

            Person p = new Person();
            Console.WriteLine(p.age);

            Person p2 = new Person(23, "moshe");

            Console.WriteLine(DateTime.Now.Year);

        }
    }
    class Person
    {
        public int age { get; set; }
        public string name { get; set; }

        public Person():this(20,"dina")
        {
            //age = 20;
            //name = "dina";
        }
        public Person(int age, string name)
        {
           this.age = age;
           this.name = name;
        }

    }
}
