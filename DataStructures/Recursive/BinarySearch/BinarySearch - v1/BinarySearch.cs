using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearch___v1
{
    public class BinarySearch<T>
    {
        public int Search(int[] array, int target)
        {
            if(target != 0 )
            return SearchHelper(array, target, 0, array.Length-1);

            return -1;
        }

        public int SearchHelper(int[] array, int target, int left, int right)
        {
            if (left > right)
                return -1;

            int middle = (left + right) / 2;
            int currentItem = array[middle];

            if ( target == currentItem)
                return middle;

            if ( target < currentItem )
                return SearchHelper(array, target, left, middle - 1);
            else
                return SearchHelper(array, target, middle + 1, right);
        }
    }

   
}
