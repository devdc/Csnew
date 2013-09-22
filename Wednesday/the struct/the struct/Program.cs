using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p=new Point();
            Point.y = 123;
            p.X = 30; 


        }
    }
    struct Point
    {
        public static int y;
        public Point(int x)
        {
            X = x;
        }
        public int X;// { get; set; }
        public void Print()
        {
            Console.WriteLine(X);
        }
    }
}
