using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class LeapYear
    {
        public static void CheckingLeapYear()
        {


            Console.WriteLine("Enter a year In Four Digit Number");
            int year = Convert.ToInt32(Console.ReadLine());
            if ((year % 4) == 0 && (year % 100) != 0)
            {
                Console.WriteLine("it is a leapyear:" + year);
            }
            else
            {
                Console.WriteLine("it is not leapyear" + year);
            }
        }
    }

}

        
   

