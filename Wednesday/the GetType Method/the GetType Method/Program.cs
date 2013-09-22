using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace the_GetType_Method
{
    class Program
    {
        static void Main(string[] args)
        {
           // string x = "abc";
            class1 x = new class1();
            Type t = x.GetType();
           // Console.WriteLine(t.Name);
            //Console.WriteLine(t.IsClass);
            //Console.WriteLine(t.FullName);

            MethodInfo[] arr = t.GetMethods(BindingFlags.Public| BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (MethodInfo i in arr)
            {
                Console.WriteLine(i.Name);
            }

            //MethodInfo m = t.GetMethod("a");
            //m.Invoke(x, null);

            //MethodInfo m = t.GetMethod("c", BindingFlags.NonPublic | BindingFlags.Instance);
            //m.Invoke(x, null);
        }
    }
    class class1
    {
        public void a()
        {
            Console.WriteLine("hello");
        }
        public void b(string n)
        {
            Console.WriteLine("hello "+n);
        }
        private void c()
        {
            Console.WriteLine("shhh i am private");
        }
    }
}
