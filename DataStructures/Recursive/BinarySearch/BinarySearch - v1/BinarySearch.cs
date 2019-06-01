using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearch___v1
{
    public class BinarySearch<T>  
    {      
        public int Search(T[] array, T target)
        {            
            if(!String.IsNullOrEmpty(target.ToString()))
                
              return SearchHelper(array, target, 0, array.Length - 1);
           
            return -1;
        }

        private int SearchHelper(T[] array, T target, int left, int right)
        {
            if (left > right)
                return -1;

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

            if (comparer.Compare(currentItem, target) == 0)
                return middle;
            else if (comparer.Compare(currentItem, target) > 0)
                 
                return SearchHelper(array, target, left, middle - 1);
            else
                 
                return SearchHelper(array, target, middle + 1, right);
        }

    }
    
}
