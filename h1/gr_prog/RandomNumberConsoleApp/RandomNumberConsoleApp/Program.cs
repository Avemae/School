using System;

namespace RandomNumberConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opgave 4
            Console.WriteLine("Skriv det første tal:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv det andet tal:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gæt på et tal!");
            int guess = Convert.ToInt32(Console.ReadLine());

            Random randomNumber = new Random();
            int currentNumber = randomNumber.Next(firstNumber, secondNumber);

            if (guess == currentNumber)
            {
                Console.WriteLine("Du gættede rigtigt!");
            }
            else
            {
                Console.WriteLine($"Du gættede forkert! Det rigtige tal var: {currentNumber}");
            }
        }
    }
}
