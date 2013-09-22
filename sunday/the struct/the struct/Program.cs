using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_struct
{
   public struct Employee
    {
        public int id;
        public string name;
        public string email;
        public void Print()
        {
            Console.WriteLine("employee: id={0} first name={1} email address={2}",id,name,email);
        }
            
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1;
            emp1.id = 123;
            emp1.name = "david";
            emp1.email = "david@gmail.com";

            Employee emp2;
            emp2.id = 456;
            emp2.name = "dina";
            emp2.email = "dina@walla.com";


            emp1.Print();
            emp2.Print();
            //Console.WriteLine(emp1.email);
        }
    }
}
