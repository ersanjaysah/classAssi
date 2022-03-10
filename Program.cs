using System;

namespace Date9Assignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter number you want to flip");
            int tossnumber=int.Parse(Console.ReadLine());
            class1.flip(tossnumber);

            Console.WriteLine("please enter year");
            int year = int.Parse(Console.ReadLine());
            bool isleapyear=Class2.isLeapYear(year);
            Class2.isleap(isleapyear, year);
        }
    }
}
