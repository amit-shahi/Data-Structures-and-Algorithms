using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearch_Iterative___v1
{
    public class BinarySearch<T>
    {
        public int Search(T[] array, T target)
        {
            if (!String.IsNullOrEmpty(target.ToString()))

                return SearchHelper(array, target, 0, array.Length - 1);

            return -1;
        }

        private int SearchHelper(T[] array, T target, int left, int right)
        {

            //if (left > right)
            //    return -1;

            while (left <= right)
            {

                // NOTE: This will cause integer overflow issues
                //int middle = (left + right) / 2;

                // NOTE: To prevent interger overflow issues, use
                int middle = left + ((right - left) / 2);

                var currentItem = array[middle];



                // Integer binary search implementation


                //if (target == currentItem)
                //    return middle;

                //if (target < currentItem)
                //    return SearchHelper(array, target, left, middle - 1);
                //else
                //    return SearchHelper(array, target, middle + 1, right);
                //;

                Comparer<T> comparer = Comparer<T>.Default;

                // Generic binary search implementation for string & integer

                // Check if target is present at middle position  

                if (comparer.Compare(currentItem, target) == 0)
                    return middle;

                // Check if target is smaller then middle position, ignore right half   
                else if (comparer.Compare(currentItem, target) > 0)
                    
                    right = middle - 1;
                // Check if target is greater then middle position, ignore left half  
                else

                    left = middle + 1;
            }

            return -1;
        }
    }
}
