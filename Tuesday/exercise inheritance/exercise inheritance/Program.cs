using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            c.X = 11;
            c.Y = 12;
            c.Radius = 5;
            c.Print();

            Rectangle r = new Rectangle { X = 3, Y = 4, Width = 7, Height = 8 };
            r.Print();
        }
    }
}
