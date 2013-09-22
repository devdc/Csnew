using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_interface
{
    class Program
    {
        static void Main(string[] args)
        {

        }

    }

    public interface IPerson
    {
        int id { get; set; }
        string name { get; set; }

        void Greeting(string i);
    }

    public interface IHuman
    {
        void SayHello();
    }
    class Person
    { }
    class Customer:Person, IPerson,IHuman
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public void Greeting(string j)
        {
            Console.WriteLine("hello "+j);
        }
        public void SayHello()
        {
            Console.WriteLine("hello hello hello");
        }
    }
}
