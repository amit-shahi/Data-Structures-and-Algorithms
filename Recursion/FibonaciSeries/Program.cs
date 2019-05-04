using System;
using static System.Console;

namespace FibonaciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                WriteLine("Generate Fibonacci Series for given number: ");
                int number = Convert.ToInt32(ReadLine());

                WriteLine($"Fibonacci Series for given number {number}: ");

                if(number > 0)
                 {
                     for(int i=0; i <=number ; i++)
                     {                     
                        int result = FibonacciSeries(i);
                        Write(result + " ");                       
                     }                   
                 }
                else
                {
                    WriteLine(0);
                }


            }
            catch(Exception ex)
            {
                WriteLine(ex.Message.ToString());
            }

        }

        static int FibonacciSeries(int number)
        {
            if(number == 0 || number == 1)
            return number;
             
            int result = FibonacciSeries(number - 1) + FibonacciSeries(number - 2);
                       
            return result;
        }
    }
}
