using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class LargestAmongThreeNumbers
    {
        public static void LargestThreeNumbers()
        {
            Console.WriteLine("Finding the largest three numbers:");
            Console.WriteLine("Enter your 1st value:");
            int val1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your 2nd value:");
            int val2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your 3rd value:");
            int val3 = Convert.ToInt32(Console.ReadLine());

            if (val1 > val2 && val1 > val3)
            {
                Console.WriteLine("The 1st value is greatest:" + val1);
            }
            else if (val2 > val1 && val2 > val3)
            {
                Console.WriteLine("The 2nd value is greatest:" + val2);
            }
            else if (val3 > val1 && val3 > val2)
            {
                Console.WriteLine("The 3rd value is greatest:" + val3);
            }
        }
    }
}
