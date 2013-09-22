using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[4];
            arr[0] = 111;
            // Console.WriteLine(arr[0]);

            int[] arr2;
            arr2 = new int[] { 1, 22, 3, 9 };
            int[] arr3 = { 1, 2, 3 };


            int[,] arr4 = new int[3, 4];
            arr4[1, 2] = 20;


            // Console.WriteLine(arr4.Length);
            // Console.WriteLine(arr4.GetLength(1));
            //Console.WriteLine(arr4.Rank);


          //  Array.Sort(arr2);
            //foreach (int i in arr2.Reverse())
            //foreach (int i in arr2)
            //{
            //    Console.WriteLine(i);
            //}

          //  Console.WriteLine(Array.IndexOf(arr2,31));

            int[][] arr5 = new int[3][];

            arr5[0] = new int[4];
            arr5[1] = new int[7];

            arr5[1][5] = 12;


        }
    }
}
