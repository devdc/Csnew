using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace more_about_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            class1 x = new class1();
            ((IPerson)x).Greeting();
        }
    }
    interface IPerson
    {
        void Greeting();
    }
    interface IHuman//:IPerson
    {
        void SayHello();
        void Greeting();
    }

    class class1 : IPerson,IHuman
    {
        void IPerson.Greeting()
        {
            Console.WriteLine("hello 123");
        }

        void IHuman.SayHello()
        {
           
        }

        void IHuman.Greeting()
        {
           
        }
    }

    
    
    //class class1 : IHuman
    //{
    //    public void SayHello()
    //    {
           
    //    }

    //    public void Greeting()
    //    {
           
    //    }
    //}

}
