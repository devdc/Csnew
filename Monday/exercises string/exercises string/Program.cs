using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises_string
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("please enter first data: ");
            //string s1 = Console.ReadLine();
            //Console.Write("please enter second data: ");
            //string s2 = Console.ReadLine();

            //int count = 0, location = -1;

            //do
            //{
            //    location = s1.IndexOf(s2, ++location);
            //    if (location>-1)
            //    {
            //        count++;
            //    }
            //} while (location>-1);
            //Console.WriteLine(count);

            char c = 't';
            Console.WriteLine((int)c);


            Console.Write("please enter first data: ");
            string s1 = Console.ReadLine();

            //char.IsDigit( s1[3])

            string t = "0123456789";
            bool flag = true;
            for (int i = 0; i < s1.Length; i++)
            {
                if (t.IndexOf(s1[i])==-1)
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("number");
            }
            else
            {
                Console.WriteLine("char");
            }
        }
    }
}
