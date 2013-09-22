using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace example_event
{
    //****** step 0 declare the delegate
    public delegate void ledHandler(string message);

    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            //*******  step 3 connect the car's event to the function with a delegate
           // c.TooHot += new ledHandler(theFun);
            c.Drive();
        }


        //************** step 4 the function for the event
        static void theFun(string msg)
        {
            Console.WriteLine("the message from the car is: "+msg);
        }
    }
    //******************************************************************************
    class Car
    {
        //******** step 1 declare the event of the delegate type
        public event ledHandler TooHot;

        public void Drive()
        {
            Console.WriteLine("the car is driving...");
            Thread.Sleep(4000);
            //********** step 2 raise the event
            if(TooHot!=null)
               TooHot("the engine temp is too high");

        }
    }
}
