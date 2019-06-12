using System;
using static System.Console;

namespace Fibonacci_Bottom_up_Solution
{
    class Program
    {
        static int Find_Fibonacci(int n)
        {
            int[] firstTwo = { 0, 1 };
            int counter = 3;

            int nextFib;

            if (n == 1)
                return firstTwo[0];
            else
            {

                while (counter <= n)
                {
                    nextFib = firstTwo[0] + firstTwo[1];
                    firstTwo[0] = firstTwo[1];
                    firstTwo[1] = nextFib;
                    counter++;
                }
                return firstTwo[1];
            }

            
        }

        static void Main(string[] args)
        {
            WriteLine("Fibonacci Bottom up (Iterative) Solution");
            WriteLine();

            WriteLine("The Fibonacci sequence is defined as follows: the first number of the sequence is 0, the second number is 1, and the nth number is the sum of the (n - 1)th and (n - 2)th numbers.");
            WriteLine();

            WriteLine("Function that takes in an integer number and returns the nth Fibonacci number");
            //WriteLine("Return Fibonacci Number for the given number.");
            WriteLine("Enter the an integer number.");

            int number = Convert.ToInt32(ReadLine());

            //int[] memo = new int[10];
            long result = Find_Fibonacci(number);

            WriteLine($"Fibonacci Number at position {number} is: {result}");
            ReadKey();

        }
    }
}
