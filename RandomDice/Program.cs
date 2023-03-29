using System;

namespace RandomDice
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please input how many 1d6 dices you want to throw:");
            int n = int.Parse(Console.ReadLine()!);

        }
    }
}
