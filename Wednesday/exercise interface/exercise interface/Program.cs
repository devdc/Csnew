using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            Cat c = new Cat();
            Tiger t = new Tiger();
            Chair ch = new Chair();
            IsAnimal(d);
            IsAnimal(c);
            IsAnimal(t);
            IsAnimal(ch);
        }
        static void IsAnimal(object x)
        {
            if (x is IAnimal)
            {
                //((IAnimal)x).MakeSound();

               // (x as IAnimal).MakeSound();

                IAnimal ia = (IAnimal)x;
                ia.MakeSound();
            }
            else
            {
                Console.WriteLine("object isn't an animal");
            }
        }
    }

    public interface IAnimal
    {
        void MakeSound();
    }
    public class Dog : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("how how");
        }
    }
    public class Cat : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("miau miau");
        }
    }
    public class Tiger : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("ahhhhhhhhhhhhhhhh");
        }
    }
    class Chair
    { }


}
