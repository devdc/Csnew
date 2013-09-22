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

            List<Shape> arr = new List<Shape>();
            ConsoleKeyInfo ck;
            do
            {
                Console.Write("please c-add circle, r-add rectangle, p-print, e-exit: ");
                ck = Console.ReadKey();
                Console.WriteLine();
                switch (ck.KeyChar)
                {
                    case 'c':
                        Circle c = new Circle(1, 2, 3);
                        arr.Add(c);
                        break;
                    case 'r':
                        arr.Add(new Rectangle(4, 5, 6, 7));
                        break;
                    case 'p':
                        foreach (object s in arr)
                        {
                            if (s is Circle)
                            {
                                
                                Console.WriteLine("radius="+ ((Circle)s).Radius  );
                            }
                            else
                            {
                                Rectangle r = s as Rectangle;
                                if (r!=null)
                                {
                                    Console.WriteLine("width="+r.Width+" height="+r.Height);
                                }
                            }
                        }
                        break;
                }

            } while (ck.KeyChar != 'e');



            //***************************** version 1
            //List<Shape> arr = new List<Shape>();
            //ConsoleKeyInfo ck;
            //do
            //{
            //    Console.Write("please c-add circle, r-add rectangle, p-print, e-exit: ");
            //    ck = Console.ReadKey();
            //    Console.WriteLine();
            //    switch (ck.KeyChar)
            //    {
            //        case 'c':
            //        Circle c = new Circle(1,2,3);
            //        arr.Add(c);
            //        break;
            //        case 'r':
            //        arr.Add(new Rectangle(4, 5, 6, 7));
            //        break;
            //        case 'p':
            //        foreach (Shape s in arr)
            //        {
            //            s.Print();
            //        }
            //        break;
            //    }
                
            //} while (ck.KeyChar!='e');


           
           
          

            
        }
    }
}
