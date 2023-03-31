using System;

namespace UpperUnion
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            // First we will check how many args were passed

            if (args.Length == 0)
            {
                Console.WriteLine("NO ARGUMENTS");
                return;
            }
            else
            {
                // Now we convert all strings to uppercase + order them alphabetically
                Array.Sort(args, StringComparer.OrdinalIgnoreCase);
            }
            
        }
    }
}
