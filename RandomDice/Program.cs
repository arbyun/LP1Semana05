using System;

namespace RandomDice
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please input how many 1d6 dices you want to throw:");
            int n = int.Parse(Console.ReadLine()!);

            int soma = 0;

            Random rando = new Random();

            for (int i = 1; i <= n; i++)
            {
                int nextRoll = rando.Next(1, 7);
                soma += nextRoll;
                Console.WriteLine($"You've rolled {nextRoll} for die number {i}.");
            }
            
            Console.WriteLine($"In total, your {n} dice(s) sum {soma}.");

        }
    }
}
