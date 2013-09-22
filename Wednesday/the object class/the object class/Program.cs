using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_object_class
{
    class Program
    {
        static void Main(string[] args)
        {
            class1 x = new class1() { age = 20, name = "rafi" };
            //Console.WriteLine(x.ToString());
            Console.WriteLine(x.GetHashCode());

            class1 y = new class1() { age = 20, name = "dina" };
            //Console.WriteLine(y.GetHashCode());

            if (x.Equals(y))
            {
                Console.WriteLine("same same");
            }
            else
            {
                Console.WriteLine("but different");
            }
            
        }
    }
    class class1
    {
        public int age { get; set; }
        public string name { get; set; }
        public override string ToString()
        {
            return "yofi tofi";
        }
        public override int GetHashCode()
        {
            return 123;
        }
        public override bool Equals(object obj)
        {
            return obj is class1 && ((class1)obj).age == age;
        }
    }
}
