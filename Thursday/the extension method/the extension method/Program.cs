using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_extension_method
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "hello";
            Console.WriteLine(s.Addaaa());
            
        }
    }

    static class class123
    {
        public static string Addaaa(this string str)
        {
            return str + "aaa";
        }
    }
}
