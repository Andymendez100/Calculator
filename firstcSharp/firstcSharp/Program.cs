using System;

namespace firstcSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            string userInput;

            Console.WriteLine("What type of calculation do you want to perform? (+, -, *, or /)");

            string userChoice = Console.ReadLine();

            Console.WriteLine("Enter first number");
            userInput = Console.ReadLine();
            int numberOne = Convert.ToInt32(userInput);

            Console.WriteLine("Enter second number");
            userInput = Console.ReadLine();
            int numberTwo = Convert.ToInt32(userInput);


            switch (userChoice)
            {
                case "+":
                    Console.WriteLine($"The answer is {numberOne + numberTwo}");
                    break;
                case "-":
                    Console.WriteLine($"The answer is {numberOne - numberTwo}");
                    break;
                case "*":
                    Console.WriteLine($"The answer is {numberOne * numberTwo}");
                    break;
                case "/":
                    Console.WriteLine($"The answer is {numberOne / numberTwo}");
                    break;
                default:
                    Console.WriteLine("Hmm you sure you typed everything correctly?");
                    break;
            }


        }
    }
}
