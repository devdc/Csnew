using System;
using System.Collections;


namespace the_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList arr1 = new ArrayList(3);
            //arr1.Add("aaa");
            //arr1.Add(123);
            //arr1.Add(true);
            //arr1.Add(123);
            //arr1.Add(true);

            ////foreach (object i in arr1)
            ////{
            ////    Console.WriteLine(i);
            ////}

            ////Console.WriteLine(arr1[1]);
            ////arr1.RemoveAt(1);
            ////Console.WriteLine(arr1[1]);

            //Console.WriteLine(arr1.Count);
            //Console.WriteLine(arr1.Capacity);

            //Queue q = new Queue();
            //q.Enqueue(1111);
            //q.Enqueue(2222);
            //q.Enqueue(3333);

            //Console.WriteLine(q.Dequeue());
            //Console.WriteLine(q.Peek());
            //Console.WriteLine(q.Dequeue());
            //Console.WriteLine(q.Count);

            //Stack s = new Stack();
            //s.Push("aaa");
            //s.Push("bbb");
            //s.Push("ccc");
            //Console.WriteLine(s.Pop());
            //Console.WriteLine(s.Peek());
            //Console.WriteLine(s.Pop());

          // Hashtable ht = new Hashtable();
            SortedList ht = new SortedList();
            ht.Add("yossi", "hertzel 30");
            ht.Add("hila", "hapardes 12");
            ht.Add("avi", "hapnina 34");

            //Console.WriteLine(ht["hila"]);
            foreach (object i in ht.Keys)
            {
                Console.WriteLine(i+" "+ht[i]);
            }
        }
    }
}
