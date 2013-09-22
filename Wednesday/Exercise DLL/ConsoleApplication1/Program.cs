using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ClassLibrary1.Class1.Add(3, 4));

            ClassLibrary1.class2 x = new ClassLibrary1.class2();
            Console.WriteLine(x.Add(3,4));
        }
    }
}
