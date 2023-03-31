using System;
using System.Text;

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
                
                // Use StringBuilder to join the strings with a hyphen
                var stringBuilding = new StringBuilder();
                stringBuilding.Append(args[0]);
                
                for (int i = 1; i < args.Length; i++)
                {
                    stringBuilding.Append('-');
                    stringBuilding.Append(args[i]);
                }

                // And then we print the final united string
                Console.WriteLine(stringBuilding.ToString());
            }
            
        }
    }
}
