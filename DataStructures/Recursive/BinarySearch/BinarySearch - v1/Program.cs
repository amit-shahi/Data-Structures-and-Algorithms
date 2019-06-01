using System;
using static System.Console;


namespace BinarySearch___v1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Binary Search for an item in a sorted array list.");
            WriteLine();

            WriteLine("1. Perform a Binary Search in a sorted list of integers.");

            int[] integerList = new int[] { 1, 13, 40, 2, 5, 25, 44, 9, -1, 7, 6 };

            BinarySearch<int> _binarySearch = new BinarySearch<int>();

            // Make sure to sort the given array of integers to make sure they are sorted.
            Array.Sort(integerList);

            int lookupInteger = _binarySearch.Search(integerList, 25);

            WriteLine();

            int index = 0;
 
            WriteLine("Sorted Array List");

            foreach (int number in integerList)
            {
                WriteLine("[" + index + "] => " + number + " ");
                index++;
            }

            WriteLine();
            WriteLine();

            if (lookupInteger != -1)
            {
                WriteLine($"Found {25} in the list at the position {lookupInteger}");
            }
            else
            {
                WriteLine("Item not found");
            }
            

        }
    }
}
