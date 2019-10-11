using System;

namespace firstcSharp
{
    class Program
    {
        static void Main(string[] args)
        {
        

            Add(1 + 2);
        }

        static void Add(int firstNum, int secNum )
        {
            int total = firstNum + secNum;
            Console.WriteLine(total);
            
        }
    }
}
