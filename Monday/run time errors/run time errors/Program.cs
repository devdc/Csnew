using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace run_time_errors
{
    class Program
    {
        static void Main(string[] args)
        {
           
          //  x = 11;

          //  if (x<20)
            {
                int a = 200;
            }

           // Console.WriteLine(a);
            decimal x, y, z;
            try
            { 
               
                Console.Write("please enter a number: ");
                x = decimal.Parse(Console.ReadLine());
                if (x > 20)
                {
                  //  return;
                    throw new FormatException();
                }
                Console.Write("please enter another number: ");
                y = decimal.Parse(Console.ReadLine());
                z = x / y;
                Console.WriteLine("z=" + z);
            }

            catch (DivideByZeroException ex)
            {
                z = 1;
                Console.WriteLine(ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("noo noo noo");
            }
            catch (Exception ex)
            {
                Console.WriteLine("error :)\n " + ex.ToString());
            }
            finally
            {
                Console.WriteLine("fin");
            }

            Console.WriteLine("end of program");
        }


    }
}
