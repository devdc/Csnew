using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_Generic
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> arr1 = new List<string>();
            arr1.Add("aaa");
            arr1.Add("bbb");
           // arr1.Add(123);

            List<int> arr2 = new List<int>();
            arr2.Add(111);
            arr2.Add(222);
           // arr2.Add("aaa");

            Book b;
            b.Title = "Cinderella";
            b.pages = 50;

            List<Book> arr3 = new List<Book>();
            arr3.Add(b);

            Console.WriteLine(arr3[0].Title);
        }
    }
    struct Book
    {
        public string Title;
        public int pages;

    }
}
