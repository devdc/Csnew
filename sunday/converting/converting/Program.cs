using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace converting
{
    class Program
    {
        static void Main(string[] args)
        {

           System.Int32 x2 = 4;
            int x = 4;

           
            long y = 3;
            string z = "2";
            String z2;

            x =(int)y;
            y =(long)x;
            z = x.ToString();
            x = int.Parse(z);

            //double.Parse(
           // bool.Parse(

            x = Convert.ToInt32(y);
            x = Convert.ToInt32(z);
            y = Convert.ToInt64(x);
            z = Convert.ToString(x);

            byte bt1 = 120;
           

        }
    }
}
