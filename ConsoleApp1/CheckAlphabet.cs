using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class CheckAlphabet
    {
        public static void CheckVowel()
        {
            char alphabet;
            Console.WriteLine("Enter a alphabet");
            alphabet = Convert.ToChar(Console.ReadLine());
            switch (alphabet)
            {
                case 'a':
                    Console.WriteLine($"{alphabet} is a vowel");
                    break;
                case 'e':
                    Console.WriteLine($"{alphabet} is a vowel");
                    break;
                case 'i':
                    Console.WriteLine($"{alphabet} is a vowel");
                    break;
                case 'o':
                    Console.WriteLine($"{alphabet} is a vowel");
                    break;
                case 'u':
                    Console.WriteLine($"{alphabet} is a vowel");
                    break;
                default:
                    Console.WriteLine($"{alphabet} is a Consonent");
                    break;
            }
        }
    }
}
