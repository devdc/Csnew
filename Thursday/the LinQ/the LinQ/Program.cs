using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_LinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "avi", "dina", "simcha", "yossef" };
            int[] arr = { 1, 2, 3, 5 };

           // Console.WriteLine(arr.Sum());

            //var q = from n in names
            //        where n.Length > 3
            //        select n;

            var q = names.Where((n) => n.Length > 3);

            foreach (string i in q)
            {
                Console.WriteLine(i);
            }
        }
    }
}
