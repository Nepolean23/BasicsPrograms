using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class QuotientAndReminder
    {
        public static void CheckingQuotientAndReminder()
        {
            Console.WriteLine("Enter a value for divident:");
            int divident = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a value for divisor:");
            int divisor = Convert.ToInt32(Console.ReadLine());
            int quotient = divident / divisor;
            int reminder = divident % divisor;
            Console.WriteLine("Quotient:" + quotient);
            Console.WriteLine("Reminder:" + reminder);
        }
    }
}
