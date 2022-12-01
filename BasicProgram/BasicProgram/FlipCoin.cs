using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class FlipCoin
    {
        public static void FlipCoinMethod()
        {
            {

                int head = 0, tail = 0, headPer, tailPer;
                Console.WriteLine("Flipping of coin");
                Console.WriteLine("Enter a value for number of flips");
                int val1 = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < val1; i++)
                {
                    Random random = new Random();
                    int coin = random.Next(0, 2);
                    if (coin == 0)
                    {
                        Console.WriteLine("Its head");
                        head++;
                    }
                    else
                    {
                        Console.WriteLine("Its tail");
                        tail++;
                    }
                }
                headPer = head * 100 / val1;
                tailPer = tail * 100 / val1;
                Console.WriteLine("total no of head count: " + head);
                Console.WriteLine("total no of tail count: " + tail);
                Console.WriteLine("Percentage of head: " + headPer + "%");
                Console.WriteLine("Percentage of tail: " + tailPer + "%");
            }
        }
    }
}
