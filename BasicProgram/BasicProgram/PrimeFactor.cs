using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class PrimeFactor
    {
        public static void PrimeFactorNumber()
        {
            Console.WriteLine("Enter a number to find prime number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int divisor = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    divisor++;
                }
            }
            if (divisor == 2)
            {
                Console.WriteLine("It is a prime number:" + number);
            }
            else
            {
                Console.WriteLine("It is not a prime number:" + number);
            }
        }
    }
}
