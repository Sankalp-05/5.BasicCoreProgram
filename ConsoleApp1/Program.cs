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
        }
    }
}