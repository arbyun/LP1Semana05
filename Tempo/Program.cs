using System;
using System.Diagnostics;
using System.Threading;

namespace Tempo
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            // Type of var => Stopwatch
            Stopwatch chrono1 = Stopwatch.StartNew();
            Stopwatch chrono2 = Stopwatch.StartNew();
            
            chrono1.Start();
            Thread.Sleep(500);
            chrono2.Start();
            Thread.Sleep(300);
            chrono1.Stop();
            chrono2.Stop();

            double chrono1String = chrono1.ElapsedMilliseconds / 1000.0;
            double chrono2String = chrono2.ElapsedMilliseconds / 1000.0;
            
            Console.WriteLine($"First timer => {Math.Round(chrono1String, 2)} seconds");
            Console.WriteLine($"Second timer => {Math.Round(chrono2String, 2)} seconds");
        }
    }
}
