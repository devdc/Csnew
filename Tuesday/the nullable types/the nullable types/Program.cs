using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_nullable_types
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.name = "hila";
            Console.WriteLine(p.age);
            if (p.name!=null)
            {
                Console.WriteLine(p.name);
            }
            else
            {
                Console.WriteLine("en shem");
            }
            //Console.WriteLine(p.IsHappy);
            p.IsHappy = true;

            if (p.IsHappy!=null)
            {
                Console.WriteLine("person is happy");
            }

           
            //p.IsHappy.HasValue
            //p.height.HasValue

            //p.IsHappy.GetValueOrDefault()
            p.height = 200;
            Console.WriteLine(p.height??190);
        }
    }
    class Person
    {
        public int age { get; set; }
        public string name { get; set; }

        public bool? IsHappy { get; set; }
        public Nullable<int> height { get; set; }
    }
}
