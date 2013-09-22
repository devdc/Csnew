using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_inheritance
{
    class Circle:Shape
    {
        public int Radius { get; set; }
        public Circle(int x,int y,int r):base(x,y)
        {
            Radius = r;
        }
        public override void Print()
        {
            Console.Write("Circle ");
            base.Print();
            Console.WriteLine(" radius="+Radius);
        }
    }
}
