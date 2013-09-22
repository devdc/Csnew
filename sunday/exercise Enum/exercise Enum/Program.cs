using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_Enum
{
    enum WeekDays
    {Sunday=1,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please enter day number 1-7: ");
            string strDay = Console.ReadLine();
            int iDay = int.Parse(strDay);
            WeekDays wd = (WeekDays)iDay;
            Console.WriteLine("the day is: "+wd);
        }
    }
}
