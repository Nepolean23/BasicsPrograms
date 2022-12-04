using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class PowerOfTwo
    {
        public static void PowerOfBase()
        {
            Console.WriteLine("Enter a base number for exponent of 2");
            int val1 = Convert.ToInt32(Console.ReadLine());
            int pow = (int)Math.Pow(2, val1);
            for (int i = 0; i < val1; i++)
            {
                Console.WriteLine("The power of 2 of:" + i + "is:" + Math.Pow(2, i));
            }
        }
    }
}
