using System;
using firstcSharp.Calculator;

namespace firstcSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }
        static void Start()
        {
            string userInput;


            string userChoice = Calculation();

            int numberOne = FirstNum();


            int numberTwo = SecondNum();


            switch (userChoice)
            {
                case "+":
                    Calculations.Add(numberOne, numberTwo);
                    Restart();

                    break;
                case "-":
                    Calculations.Subtract(numberOne, numberTwo);
                    Restart();
                    break;
                case "*":
                    Calculations.Multiply(numberOne, numberTwo);
                    Restart();
                    break;
                case "/":
                    double total = numberOne / numberTwo;
                    Calculations.Divide(numberOne, numberTwo);
                    Restart();
                    break;
                default:
                    Console.WriteLine("Hmm this is an interesting Bug...");
                    break;
            }
        }
        static string Calculation()
        {
            Console.WriteLine("What type of calculation do you want to perform? (+, -, *, or /)");

            string answer = Console.ReadLine();
            if (answer != "+" && answer != "-" && answer != "*" && answer != "/")
            {
                Console.WriteLine("Please pick something that is actually an option...");
                Calculation();
            }

            return answer;


        }
        static int FirstNum()
        {
            int value;
            Console.WriteLine("Enter first number");
            string userInput = Console.ReadLine();
            if (!int.TryParse(userInput, out value))
            {
                Console.WriteLine("Please insert a correct number -.-");
                FirstNum();
            }
            return value;
        }
        static int SecondNum()
        {
            int value;
            Console.WriteLine("Enter second number");
            string userInput = Console.ReadLine();
            if (!int.TryParse(userInput, out value))
            {
                Console.WriteLine("Please insert a correct number -.-");
                SecondNum();
            }
            return value;
        }
        static void Restart()
        {
            Console.WriteLine("Would you like to restart? Press y to restart");
            string userAnswer = Console.ReadLine();

            if (userAnswer == "y")
            {
                Start();
            }
            else
            {
                Console.WriteLine("Wack");
            }
        }
    }
}
