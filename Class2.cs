using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date9Assignment
{
    public class Class2
    {
        public static bool isLeapYear(int year)
        {
            if((year%400==0)||(year%100!=0&&year%4==0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool isleap(bool isleapyear,int year)
        {
            if (isleapyear)
            {
                Console.WriteLine(year + " is a leap year");
            }
            else
            {
                Console.WriteLine(year + "  is not a leap year");
            }
            return isleapyear;
            
        }

    }
}
