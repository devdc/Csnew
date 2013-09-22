using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_struct
{
    struct Point
    {
        public int x, y;
        public void Print()
        {
            Console.WriteLine("point x={0} y={1}",x,y);
        }
       
    }

    struct Line
    {
        public Point start, end;
        public void Print()
        {
            //Console.WriteLine("start point x={0} y={1} end point x={2} y={3}",start.x,start.y,end.x,end.y);
            Console.Write("start ");
            start.Print();
            Console.Write("end ");
            end.Print();
        }
    
    }


    class Program
    {
        static void Main(string[] args)
        {
            Point p1;
            p1.x = 3;
            p1.y = 4;
            //p1.Print();

            Line k;
            k.start.x = 11;
            k.start.y = 13;
            k.end = p1;
            k.Print();

        }
    }
}
