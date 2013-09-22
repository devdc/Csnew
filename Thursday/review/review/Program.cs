using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review
{
   public delegate int calcHandler(int a,int b);
    public delegate void nameHandler(string oldName,string newName);

    class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion
            // calcHandler d1 = Add;
            // calcHandler d2 = Substract;
            // //int result=d1(3, 4);
            //// Console.WriteLine("result="+result);
            // calcHandler d3 = d1 + d2;
            //// d3(30, 4);

            // Func<int, int, int> f1 = Add;
            // f1(3, 4);

            // Action<int, string> a1 = SayHello;
            // a1(12, "sima");

            // Predicate<int> p1 = IsBig;
            // Console.WriteLine(p1(290)); 
            #endregion

            class1 x = new class1();
            x.NameChanged += x_NameChanged;
            x.FirstName = "chaim";
            x.FirstName = "moshe";
        }

        static void x_NameChanged(string oldName, string newName)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("old name is {0} new name is {1}",
                oldName,newName);
        }

        


        class class1
        {
            private string _FirstName;
            public event nameHandler NameChanged;

            public string FirstName
            {
                get { return _FirstName; }
                set 
                {  
                    if (NameChanged!=null)
                    {
                        NameChanged(_FirstName, value);
                    }
                    _FirstName = value;
                  
                }
            }
            
        }











        static bool IsBig(int i)
        {
            return i > 30;
        }
        static void SayHello(int a, string n)
        {
            Console.WriteLine(a*3);
            Console.WriteLine("hello "+n);
        }

        static int Add(int a, int b)
        {
            Console.WriteLine("adding: "+(a+b));
            return a + b;
        }
        static int Substract(int a, int b)
        {
            Console.WriteLine("substracting: "+(a-b));
            return a - b;
        }
    }



    namespace ALL
    {
        namespace Animal
        {
            class Fish
            { }
            class chicken
            { }
        }
        namespace Furnitures
        {
            class table
            { }
        }
    
    }

   internal interface IPerson
    {
        void Dosomething(int i);
         string FirstName { get; set; }
    }

   public class person
    { }

   public class Customer :person, IPerson
    {
        public void Dosomething(int i)
        {
            throw new NotImplementedException();
        }

        public string FirstName
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }

}
