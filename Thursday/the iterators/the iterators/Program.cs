using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_iterators
{
    class Program
    {
        static void Main(string[] args)
        {
            class1 x = new class1();
            foreach (string s in x)
            {
                Console.WriteLine(s);
            }
        }
    }

    class class1:IEnumerable,IEnumerator
    {
        string[] names = { "dina", "rina", "sima", "tzila" };
        int z = -1;
        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public object Current
        {
            get { return names[z]; }
        }

        public bool MoveNext()
        {
            z++;
            if (z<names.Length)
            {
                return true;
            }
            return false;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
