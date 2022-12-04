using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class SwapTwoNumbers
    {
        public static void SwapingNumbers()
        {
            Console.WriteLine("Enter a value for a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a value for b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" a:" + a + " b:" + b);
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("swaped value:" + "a:" + a + " b:" + b);
        }
    }
}
