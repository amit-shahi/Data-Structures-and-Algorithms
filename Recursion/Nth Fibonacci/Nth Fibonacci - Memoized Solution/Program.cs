using System;
using static System.Console;

namespace Fibonacci_Memoized_Solution
{
    class Program
    {
        static int Find_Fibonacci(int n, int[] memo)
        {
            int result=0;

            if(memo[n] != 0)
                return memo[n];

            //if(n == 1 || n == 2)
            //    result = 1;
            if (n == 1)
                result = 0;
            else if (n == 2)
                result = 1;
            else
                result = Find_Fibonacci(n - 1, memo) + Find_Fibonacci(n - 2, memo);
                memo[n] = result;
            return result;
        }

        static void Main(string[] args)
        {
            WriteLine("Fibonacci Memoized (Store) Solution - Dynamic Programming");
            WriteLine();

            WriteLine("The Fibonacci sequence is defined as follows: the first number of the sequence is 0, the second number is 1, and the nth number is the sum of the (n - 1)th and (n - 2)th numbers.");
            WriteLine();

            WriteLine("Function that takes in an integer number and returns the nth Fibonacci number");
            //WriteLine("Return Fibonacci Number for the given number.");
            WriteLine("Enter the an integer number.");

            int number = Convert.ToInt32(ReadLine());

            int[] memo = new int[10];
            long result = Find_Fibonacci(number, memo);

            WriteLine($"Fibonacci Number at position {number} is: {result}");
            ReadKey();

        }
    }
}
