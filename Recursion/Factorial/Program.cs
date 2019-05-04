using System;
using static System.Console;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                WriteLine("Factorial of a Number: ");
                
                UInt64 number = Convert.ToUInt64(Console.ReadLine());

                if(number < 0)
                {
                    WriteLine($"Invalid input. Can't find factorial of negative number: {number}");                    
                }
                else
                {   
                    UInt64 factorial = Factorial(number);
                    WriteLine($"Factorial of a given number {number} is: {factorial}");
                }
            }
            catch(Exception ex)
            {
                WriteLine(ex.Message.ToString());
            }
        }

        static UInt64 Factorial(UInt64 number)
        {
            if(number == 0)
            return 1;

            UInt64 factorial = number * Factorial(number -1);
            return factorial;
        }


    }
}
