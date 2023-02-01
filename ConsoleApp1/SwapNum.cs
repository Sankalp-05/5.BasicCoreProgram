using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class SwapNumber
    {
        public static void SwapNum()
        {
            //variable
            int a, b;
            //input from user
            Console.WriteLine("Enter the 1 number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 2 number");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Before Swap a = {a}, b = {b}");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"After Swap a = {a}, b ={b}");
        }
    }
}
