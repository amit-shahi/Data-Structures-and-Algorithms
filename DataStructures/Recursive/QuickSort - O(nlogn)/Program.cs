using System;
using static System.Console;

namespace QuickSort___O_nlogn_
{
    class Program
    {
        static void QuickSort(int[] array)
        {
            // Call Recursive Method
           
            QuickSort(array, 0, array.Length -1);
        }

        private static void QuickSort(int[] array, int left, int right)
        {
            
            // Check for an empty or null array
            
            if (array == null || array.Length == 0){
                return;
            }
            
            if(left >= right)
            {
                return;
            }
            
            // Get the pivot element from the middle of the sub array
            
            int middle = (left+right)/2;

            int pivot = array[middle];

            // Divide / Partition an array into two sub arrays

            int index = Partition(array, left, right, pivot);
           

            QuickSort(array, left, index - 1);
            QuickSort(array, index, right);


        }

        private static int Partition(int[] array, int left, int right, int pivot)
        {
            while(left <= right)
            {
                // If the current value from the left sub array is smaller than the pivot
                // element then get the next element from the left sub array

                while (array[left] < pivot) {
                     left++;
                }

                // If the current value from the right sub array is larger than the pivot
                // element then get the next element from the right sub array

                while (array[right] > pivot) {
                    right--;
                }

                // If we have found a value in the left sub array which is larger than
                // the pivot element and if we have found a value in the right sub array
                // which is smaller than the pivot element then we exchange the "values".
                // As we are done we can increase left and right

                if (left <= right) {
                    Swap(array, left, right);
                    left++;
                    right--;
                }

                return left;
            }

            return left; 
        }

        private static void Swap(int[] array, int left, int right) {
            int temp = array[left];
            array[left] = array[right];
            array[right] = temp;
        }


        static void Main(string[] args)
        {
            WriteLine("Quick Sort - O(nlogn) - Divide & Conquer Algorithm");
            WriteLine();

            WriteLine("Quicksort can be implemented to sort 'in-place'. This means that the sorting takes place in the array and that no additional array needs to be created.");
            
            int[] array = new int[] { 8, -1, 2, 5, 10, 1, 200, 7,-10};

            WriteLine();
            WriteLine("Given Array");
            WriteLine();

            WriteLine(String.Join(", ", array));

            // Perform a Quick Sort
            
            QuickSort(array);
          
            WriteLine();
            WriteLine("Array Sort using Quick Sort");
            WriteLine();

            WriteLine(String.Join(", ", array));

        }
    }
}
