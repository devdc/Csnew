using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_string_class
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Jerusalem";

            //Console.WriteLine(s.Length); //9
            //Console.WriteLine(s.IndexOf('r')); //2
            //Console.WriteLine(s.IndexOf("usa")); //3
            //Console.WriteLine(s.IndexOf("t")); //-1
            //Console.WriteLine(s.IndexOf("e")); //1
            //Console.WriteLine(s.IndexOf("e",4)); //7

            //Console.WriteLine(s.LastIndexOf("e")); //7
            //Console.WriteLine(s.Substring(2,4)); //rusa
            //Console.WriteLine(s.ToUpper());  //JERUSALEM
            //Console.WriteLine(s[1]); //e
            //s[1] = 't'; //ERROR

           // string[] arr = s.Split();

            s = s.Replace("e", "t");
            //Console.WriteLine(s);
            //string.Compare(

        }
    }
}
