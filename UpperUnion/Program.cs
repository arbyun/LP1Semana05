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
                string[] uppercaseArgs = new string[args.Length];

                for (int i = 0; i < args.Length; i++)
                {
                    uppercaseArgs[i] = args[i].ToUpper();
                }

                Array.Sort(uppercaseArgs, StringComparer.OrdinalIgnoreCase);
                
                // Use StringBuilder to join the strings with a hyphen
                var stringBuilding = new StringBuilder();
                stringBuilding.Append(uppercaseArgs[0]);
                
                for (int i = 1; i < uppercaseArgs.Length; i++)
                {
                    stringBuilding.Append('-');
                    stringBuilding.Append(uppercaseArgs[i]);
                }

                // And then we print the final united string
                Console.WriteLine(stringBuilding.ToString());
            }
            
        }
    }
}
