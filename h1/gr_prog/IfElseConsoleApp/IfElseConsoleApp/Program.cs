using System;

namespace IfElseConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opgave 2 del 1
            Console.WriteLine("Skriv et tal:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number == 5)
            {
                Console.WriteLine("Du skrev 5!");
            }
            // Opgave 3 del 2
            else
            {
                Console.WriteLine($"Du skrev ikke 5, du skrev {number}");
            }
        }
    }
}
