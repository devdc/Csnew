using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_string_builder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder b = new StringBuilder("simcha");
            b.Append("le");
            Console.WriteLine(b);
        }
    }
}
