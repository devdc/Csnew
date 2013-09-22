using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_new_keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            D d = new D();
            //d.Print(); //D
            C c = d;
            //c.Print();   //D
            B b = d;
            //b.Print();  //B
            A a = d;
           // a.Print();   //B

          
        }
    }
    class A
    {
        public virtual void Print()
        {
            Console.WriteLine("A");
        }
    }
    class B : A
    {
        public override void Print()
        {
            Console.WriteLine("B");
        }
    }
    class C : B
    {
        public new virtual void Print()
        {
            Console.WriteLine("C");
        }
    }
    class D : C
    {
        public override void Print()
        {
            Console.WriteLine("D");
        }
    }

}
