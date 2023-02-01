using BasicCoreProgram;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Core Program ");
            //Flip Coin 
            FlipCoin flipcoin = new FlipCoin();
            flipcoin.PercentageFlips(10);

            //Leap Year
            CheckLeapYear.LeapYear();

            //Power of 2
            PowerOf2 pow = new PowerOf2();
            pow.CheckPower(5);

            //Harmonic Number
            HarmonicNum har = new HarmonicNum();
            har.HarmonicNumber(5);


            //Prime Factorization
            PrimeFactorization.PrimeFactor();

            //to Compute Quotient and Remainder
            QuotientAndRemainder div = new QuotientAndRemainder();
            div.Divide(315, 3);

            // Swap Two Numbers
            SwapNumber.SwapNum();

            //Check Whether a Number is Even or Odd
            EvenOdd.CheckOddEven();

            //Whether alphabet is vowel or Consonant
            CheckAlphabet.CheckVowel();

            //Find the Largest Among Three Numbers
            LargestNumber.Largest();


        }
    }
}