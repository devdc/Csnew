using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parent_child_conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal { LegNumber = 4 };
            Bird b = new Bird { LegNumber = 2, CanFly = true };

           // a = b;
            
            //b =(Bird)a;

            //if (a is Bird)
            //{
            //    b = (Bird)a;
            //}

            //if (b is Animal)
            //{
            //    a = (Animal)b;
            //}


            a = b as Animal;
            if (a != null)
            {
                Console.WriteLine(a.LegNumber);
            }


            //b = a as bird;
            //if (b != null)
            //{
            //    console.writeline(b.legnumber + " " + b.canfly);
            //}

            
           
        }
    }
    class Animal
    {
        public int LegNumber { get; set; }
       
    }
    class Bird : Animal
    {
        public bool CanFly { get; set; }
    }
}
