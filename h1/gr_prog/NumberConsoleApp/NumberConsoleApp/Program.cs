using System;

namespace NumberConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opgave 2
            Console.WriteLine("Skriv det første tal:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv det andet tal, som du vil lægge til:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int result = firstNumber + secondNumber;
            Console.WriteLine($"Dit resultat er: {result}.");
        }
    }
}
