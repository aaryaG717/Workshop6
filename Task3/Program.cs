using System;

namespace FuncDelegateExample
{
    class Program
    {
        // Method that processes numbers based on a condition
        static void ProcessNumbers(int[] numbers, Func<int, bool> condition)
        {
            foreach (int number in numbers)
            {
                if (condition(number))
                {
                    Console.WriteLine(number);
                }
            }
        }

        static void Main(string[] args)
        {
            int[] numbers = { 3, 4, 7, 12, 15, 20, 9, 8 };

            Console.WriteLine("Even numbers:");
            ProcessNumbers(numbers, n => n % 2 == 0); // Func delegate for even numbers

            Console.WriteLine("\nNumbers greater than 10:");
            ProcessNumbers(numbers, n => n > 10); // Func delegate for numbers > 10
        }
    }
}
