using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            class2 x = new class2();
            x.Greeting();
            class1 y = new class1();
            //y.Greeting();

           
        }
    }
  // abstract class class1
   //sealed class class1
    class class1
    {
        public string firstName { get; set; }
        public virtual void Greeting()
        {
            
            Console.WriteLine("good afternoon "+firstName);
        }

      //  public abstract void DoSomething(int id);
        public void a()
        { 
        
        }
    }
   internal class class2:class1
    {
        //public override void DoSomething(int id)
        //{
        //    Console.WriteLine(id*3);
        //}

        public sealed override void Greeting()
        {
            base.Greeting();
            Console.WriteLine("how do you do ? ");
        }

    }
 public  class class3 : class2
    {
        //public override void Greeting()
        //{
       base.Greeting();
        //}
    }



}
