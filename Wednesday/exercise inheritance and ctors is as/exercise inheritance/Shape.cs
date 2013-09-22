using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_inheritance
{
   abstract class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Shape(int x,int y)
        {
            X = x;
            Y = y;
        }
        public virtual void Print()
        {
            Console.Write("x={0} y={1}",X,Y);
        }
    }
}
