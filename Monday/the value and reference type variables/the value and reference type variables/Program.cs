using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_value_and_reference_type_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = x;
            x = 20;
            //Console.WriteLine(y);

            StringBuilder a = new StringBuilder("simcha");
            StringBuilder b = a;
            b.Append("le");
            Console.WriteLine(a);
        }
    }
}
