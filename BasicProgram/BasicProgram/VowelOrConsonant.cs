using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class VowelOrConsonant
    {
        public static void CheckingVowelOrConsonant()
        {
            Console.WriteLine("Enter a character to find a vowel");
            char name = Convert.ToChar(Console.ReadLine());
            if (name == 'a' || name == 'e' || name == 'i' || name == 'o' || name == 'u')
            {
                Console.WriteLine("The given character:" + name + " is a vowel");
            }
            else
            {
                Console.WriteLine("The given character:" + name + " is not a vowel");
            }
        }
    }
}
