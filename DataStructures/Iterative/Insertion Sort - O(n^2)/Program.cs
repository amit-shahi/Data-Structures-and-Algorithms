using System;
using static System.Console;

namespace Insertion_Sort___O_nlogn_
{
    class Program
    {
        static int[] InsertionSort(int[] arr) 
        { 
            int i, j, newValue; 
            for (i = 1; i < arr.Length; i++) 
            { 
                    newValue = arr[i]; 
                    
                    j = i; 

                    while (j > 0 && arr[j - 1] > newValue) { 
                        arr[j] = arr[j - 1]; 
                        j--; 
                    } 

                    arr[j] = newValue; 
            } 

            return arr;
        }


        static void Main(string[] args)
        {
            WriteLine("Insertion Sort - O(n^2)");

            int[] array = new int[] { 8, -1, 2, 5, 10, 1, 200, 7,-10};

            WriteLine();
            WriteLine("Given Array");
            WriteLine();

            WriteLine(String.Join(", ", array));

            int[] result = InsertionSort(array);

            WriteLine();
            WriteLine("Array Sort using Insertion Sort");
            WriteLine();

            WriteLine(String.Join(", ", result));

        }
    }
}
