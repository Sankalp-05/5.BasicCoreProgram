using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class PrimeFactorization
    {

        public static void PrimeFactor()
        {
            int number;
            //take number from user
            Console.WriteLine("Enter the number");
            number = Convert.ToInt32(Console.ReadLine());
            //number should be greater than 1.
            while (number % 2 == 0)
            {
                Console.Write(2 + " ");
                number /= 2;
            }

            for (int i = 3; i <= number; i++)
            {
                while (number % i == 0)
                {
                    Console.Write(i + " ");

                    number /= i;
                }
            }

            if (number > 2)
            {
                Console.Write(number);
            }
        }
    }
}
