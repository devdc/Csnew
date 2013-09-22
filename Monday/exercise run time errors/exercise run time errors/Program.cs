using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_run_time_errors
{
    class Program
    {
        static void Main(string[] args)
        {
            //double.TryParse(

            int[] arr = new int[5];
            for (int i = 0; i < 5; i++)
            {
                try
                {
                    Console.Write("please enter number {0}: ", i + 1);
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("next time enter numbers");
                    i--;
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine(ex.Message);
                    
                    i--;
                }
            }
            bool flag=false;
            do
            {
                try
                {
                    flag = true;
                    Console.Write("please enter an index 0 - 4: ");
                    int index = int.Parse(Console.ReadLine());
                    Console.WriteLine("the value in index={0} is {1}", index, arr[index]);
                    flag = false;
                }
                catch (IndexOutOfRangeException)
                {

                    Console.WriteLine("next time enter a value between  0 - 4");
                }
                catch
                {
                    Console.WriteLine("call the developer");
                } 
            } while (flag);
        }
    }
}
