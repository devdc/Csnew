using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_resource_management
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GC.GetTotalMemory(false));


            //class1 x = new class1();
           // int[] arr = new int[400000];
           // arr = null;
            GC.Collect();
            Console.WriteLine(GC.GetTotalMemory(false));
            //Console.WriteLine(GC.GetGeneration(x));
            //GC.Collect();
            //Console.WriteLine(GC.GetGeneration(x));
            //GC.Collect();
            //Console.WriteLine(GC.GetGeneration(x));
            //GC.Collect();
            //Console.WriteLine(GC.GetGeneration(x));
            //GC.Collect();
            //Console.WriteLine(GC.GetGeneration(x));


            //WeakReference wr = new WeakReference(x);
            //x = null;

            //wr.IsAlive
            //wr.Target


           // for (int i = 0; i < 3000000; i++)
            //{
            //    class1 x = new class1();
            //    x.Dispose();
            //    //x = null;

            //    //GC.Collect();

            //    //System.Data.SqlClient.SqlCommand com;
            //    //com.Dispose();

            //    //System.IO.StreamWriter w;
            //    //w.Dispose();
            //}

            //using (class1 x = new class1())
            //{
            //    x.ToString();
            //}
        }

        
    }
    class class1:IDisposable
    {
        public class1()
        {
         //   Console.WriteLine("ctor");
        }

        ~class1()
        {
        //    Console.WriteLine("-----dtor");
        }

        public void Dispose()
        {
            Console.WriteLine("disposing");
           //connection.close();
            //streamReader.dispose();
        }
       
    }
}
