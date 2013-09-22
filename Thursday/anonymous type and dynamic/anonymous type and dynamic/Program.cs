using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anonymous_type_and_dynamic
{
    class Program
    {
        static void Main(string[] args)
        {

            object x = 1;
            x = "aa";
            x = true;

            var y = "hello";
            var z = true;

            var person = new { age = 33, name = "rafi" };
            //Console.WriteLine(person.name);
            //Console.WriteLine(person);
            //Console.WriteLine(person.GetType());

            var couple = new { wife = new { age = 30, name = "rivka" }, husband = new { age = 40, name = "yossi" } };

            //Console.WriteLine(couple.wife.name);

            

        }

        static void DoSomething(dynamic x)
        {
            x.blabla();
        }
    }
}
