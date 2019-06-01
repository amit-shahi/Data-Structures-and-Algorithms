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

            WriteLine("1. Perform a Recursive Binary Search in a sorted list of integers.");

            int[] integerList = new int[] { 1, 13, 40, 2, 5, 25, 44, 9, -1, 7, 6 };

            BinarySearch<int> _integerBinarySearch = new BinarySearch<int>();

            WriteLine();
            WriteLine("Given Array List");
            WriteLine(String.Join(" ", integerList));

            // Make sure to sort the given array of integers to make sure they are sorted.
            Array.Sort(integerList);

            int lookupInteger = _integerBinarySearch.Search(integerList, 25);



            WriteLine();
            WriteLine("Sorted Array List");
            WriteLine(String.Join(" ", integerList));

            //int index = 0;
            //foreach (int number in integerList)
            //{
            //    //WriteLine("[" + index + "] => " + number + " ");
            //    index++;
            //}

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

            WriteLine();
            WriteLine("***********************************************************************************");
            WriteLine();
            WriteLine("2. Perform a Recursive Binary Search in a sorted list of strings.");

            string[] stringList = new string[] { "One", "Apple", "Orange", "Mango", "Zebra", "Yummy" };

            BinarySearch<string> _stringBinarySearch = new BinarySearch<string>();

            WriteLine();
            WriteLine("Given Array List");
            WriteLine(String.Join(" ", stringList));

            // Make sure to sort the given array of integers to make sure they are sorted.
            Array.Sort(stringList);

            int lookupString = _stringBinarySearch.Search(stringList, "Mango");



            WriteLine();
            WriteLine("Sorted Array List");
            WriteLine(String.Join(" ", stringList));

            //int index = 0;
            //foreach (int number in integerList)
            //{
            //    //WriteLine("[" + index + "] => " + number + " ");
            //    index++;
            //}

            WriteLine();
            //WriteLine("lookupString: " + lookupString);

            if (lookupString != -1)
            {
                WriteLine($"Found Mango in the list at the position {lookupString}");
            }
            else
            {
                WriteLine("Item Mango not found");
            }


        }
    }
}
