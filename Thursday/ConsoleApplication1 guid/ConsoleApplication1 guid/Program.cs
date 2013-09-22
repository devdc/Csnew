using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1_guid
{
    class Program
    {
        static void Main(string[] args)
        {
            Guid x=Guid.NewGuid();
            Console.WriteLine(x);
        }
    }
}
