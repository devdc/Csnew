using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_class
{ 
  
    class Program
    {
        static void Main(string[] args)
        {
             Person p1 = new Person();
            //p1.FirstName = "moshe";
            p1.FirstName = "m";
            Console.WriteLine(p1.FirstName);

            p1.LastName = "ben david";
            Console.WriteLine(p1.LastName);
            
            p1.SetLastName("cohen");
            Console.WriteLine(p1.GetLastName());

            p1.Greeting();
            
        }
    }

    class Person
    {
        public string FirstName;
        0
        private string vLastName;

        public string LastName
        {
            set
            {
                if (value.Length < 2)
                {
                    Console.WriteLine("noo noo noo");
                }
                vLastName = value;
            }
            get
            {

                return vLastName;
            }
        
        }

        public void SetLastName(string value)
        {
            vLastName = value;
        }
        public string GetLastName()
        {
            return vLastName;
        }


        public void Greeting()
        {
            Console.WriteLine("hello "+FirstName+" "+vLastName);
        }
    
    }
}
