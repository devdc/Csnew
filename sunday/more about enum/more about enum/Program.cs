using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace more_about_enum
{
//  [Serializable] 
    //[Flags ,Serializable] 
  [Flags]  enum Weather:int
    { 
    sun=1,rain=2,cloud=4,snow=8
    }


  [Serializable]  class Program
    {
        static void Main(string[] args)
        {
           // Weather w1 = Weather.sun;
           // Weather w = Weather.sun | Weather.rain;
            Weather w = (Weather)7;
            Console.WriteLine(w);


            int x;
        }
    }
}
