using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass1Boolean
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a boolean (true or false): ");
            string input = Console.ReadLine();
            bool result;
            if (bool.TryParse(input, out result))
            {
                Console.WriteLine("Parsed boolean: " + result);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

        }
    }
}
