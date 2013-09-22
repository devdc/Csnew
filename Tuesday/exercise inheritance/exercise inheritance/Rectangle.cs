using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_inheritance
{
    class Rectangle:Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public override void Print()
        {
            Console.Write("Rectangle ");
            base.Print();
            Console.WriteLine(" width={0} height={1}",Width,Height);
        }
        public void Rectangle()
        {
           we
        }
    }
}
