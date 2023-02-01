using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class LargestNumber
    {
        public static void Largest()
        {
            int number1, number2, number3;
            Console.WriteLine("Enter 1st number");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3rd number");
            number3 = Convert.ToInt32(Console.ReadLine());
            if (number1 == number2 && number2 == number3)
                Console.WriteLine("All inputs are equal");
            if (number1 > number2 && number1 > number3)
                Console.WriteLine($"{number1} is greater");
            if (number2 > number1 && number2 > number3)
                Console.WriteLine($"{number2} is greater");
            if (number3 > number1 && number3 > number2)
                Console.WriteLine($"{number3} is greater");
        }
    }
}
