using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class EvenOrOdd
    {
        public static void CheckingEvenOrOdd()
        {
            Console.WriteLine("Enter a number to check odd or even");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine(+num + "-Its even");
            }
            else
            {
                Console.WriteLine(+num + "-Its odd");
            }
        }
    }
}
