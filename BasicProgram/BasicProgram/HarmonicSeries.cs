using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class HarmonicSeries
    {
        public static void Harmonic()
        {
            Console.WriteLine("Enter a value to find nth harmonic series");
            int H = Convert.ToInt32(Console.ReadLine());
            if (H != 0)
            {

                for (int i = 1; i <= H; i++)
                {

                    Console.Write("1/{0}+", i);

                }
            }

            else

            {
                Console.WriteLine("you have entered in valied value");
            }
            
        }
    }

}
  
