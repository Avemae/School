using System;

namespace BoolWhileConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();

            void Menu()
            {
                Console.WriteLine("Choices:");
                Console.WriteLine("1.");
                Console.WriteLine("2.");
                Console.WriteLine("Exit.");

                string returnPrint;
                string input;
                bool isRunning = true;
                while (isRunning)
                {
                    input = Console.ReadLine().ToLower();

                    if (input == "1")
                    {
                        Console.WriteLine("Write a number:");
                        int numberInput = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Write a second number:");
                        int number2Input = Convert.ToInt32(Console.ReadLine());
                        returnPrint = Console.WriteLine($"Your result is: ${PlusTwoTogether(numberInput, number2Input).");
                    }
                    else if (input == "2")
                    {

                    }
                    else if (input == "exit")
                    {
                        isRunning = false;
                    }
                    else
                    {
                        Console.WriteLine("Try something typing something else.");
                    }
                }
            }
            static int PlusTwoTogether(int number, int number2)
            {
                return number + number2;
            }
        }
        


    }

    
}
