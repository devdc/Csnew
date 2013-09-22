using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//using System.Reflection.Emit;
namespace the_Enum
{
    //enum Color:byte
    //{ blue=20,green=4,yellow=7 }

    enum Color : byte
    { blue = 20, green , yellow }

   
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = 3;

            Color y;
            y = Color.green;
            Console.WriteLine((byte)y);

            //ILGenerator il;
            //il.Emit(

           // System.IO.FileAccess.Write;
            //FileAccess.Write;

        }
    }
}
