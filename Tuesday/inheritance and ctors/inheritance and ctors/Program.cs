using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_and_ctors
{
    class Program
    {
        static void Main(string[] args)
        {
            class2 x = new class2(2, "a", 4444.56);
        }
    }
    class class1
    {
        public int id { get; set; }
        public string name { get; set; }
        public class1(int i,string n)
        {
            id = i;
            name = n;
        }
    }
    class class2 : class1
    {
        public double salary { get; set; }
        public class2(int j,string k,double d):base(j,k)
        {
            salary = d;
        }
    }
}
