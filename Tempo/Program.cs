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
        }
    }
}
