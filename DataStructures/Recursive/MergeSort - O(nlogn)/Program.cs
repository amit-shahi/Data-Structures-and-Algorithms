using System;
using static System.Console;

namespace MergeSort___O_nlogn_
{
    class Program
    {
        public static int[] mergeSort(int[] array)
        {
            int[] left;
            int[] right;

           // base case
            
           //As this is a recursive algorithm, we need to have a base case to avoid an infinite recursion which will cause stackoverflow exception.

            if (array.Length <= 1)
                return array;     

            // The exact midpoint of an array  
            int midPoint = array.Length / 2;  

            //Will represent a 'left' array
            left = new int[midPoint];
  
            //if an array has an even number of elements, the left and right array will have the same number of elements

            if (array.Length % 2 == 0)
                right = new int[midPoint];  
            //if array has an odd number of elements, the right array will have one more element than left
            else
                right = new int[midPoint + 1];  

            
            //build left array
            for (int i = 0; i < midPoint; i++)
                left[i] = array[i];  

            //build right array   
            int rightArrIndex = 0;
            //We start our index from the midpoint, as we have already populated the left array from 0 to  midpont
            for (int i = midPoint; i < array.Length; i++)
            {
                right[rightArrIndex] = array[i];
                rightArrIndex++;
            }  
           

           
           //Recursively sort the left array
            int[] leftHalf = mergeSort(left); 
           
           //Recursively sort the right array
            int[] rightHalf = mergeSort(right); 

            // Merge Both Left & Right Array to get final sorted Array
            return MergeHalves(leftHalf, rightHalf);

        }

        private static int[] MergeHalves(int[] leftHalf, int[] rightHalf)
        {
            int[] sortedArray = new int[leftHalf.Length + rightHalf.Length];

            int k = 0;
            int i = 0;
            int j = 0;

            while (i < leftHalf.Length && j < rightHalf.Length)
            {
                if (leftHalf[i] <= rightHalf[j])
                {
                    sortedArray[k++] = leftHalf[i++];
                }
                else
                {
                    sortedArray[k++] = rightHalf[j++];
                }
            }


            while (i < leftHalf.Length)
            {
                sortedArray[k++] = leftHalf[i++];
            }

            while (j < rightHalf.Length)
            {
                sortedArray[k++] = rightHalf[j++];
            }

            return sortedArray;
        }


        static void Main(string[] args)
        {
            WriteLine();
            WriteLine("Merge Sort - O(nlogn) - Divide & Conquer Algorithm");
            WriteLine();

            // Best, Average, Worst Case Time Complexity : O(nlog(n)) | Space Complexity - O(nlog(n))
            // 


            WriteLine("Time Complexity - O(N log (N)) - for creating sub arrays");
            WriteLine("Space Complexity - O(N log (N)) - for using call stack for recursive calls.");
            WriteLine();

            WriteLine("It divides input array in two halves, calls itself for the two halves and then merges the two sorted halves. The MergeHalves() function is used for merging two halves for sorted array.");

            int[] array = new int[] { 8, -1, 2, 5, 10, 1, 200, 7, -10 };
             

            WriteLine();
            WriteLine("Given Array");
            WriteLine();

            WriteLine(String.Join(", ", array));

            // Perform a Merge Sort

            int[] result = mergeSort(array);

            WriteLine();
            WriteLine("Array Sort using Merge Sort");
            WriteLine();

            WriteLine(String.Join(", ", result));

        }
    }
}
