using System;
using System.Collections.Generic;
using System.Text;

namespace firstcSharp.Calculator
{
    public class Calculations
    {
        public static void Add(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine($"The answer is {result}");


        }
        public static void Subtract(int num1, int num2)
        {
            int result = num1 - num2;

            Console.WriteLine($"The answer is {result}");
        }
        public static void Multiply(int num1, int num2)
        {
            int result = num1 * num2;

            Console.WriteLine($"The answer is {result}");
        }
        public static void Divide(int num1, int num2)
        {
            double result = num1 / num2;

            Console.WriteLine($"The answer is {result}");
        }
    }
}
