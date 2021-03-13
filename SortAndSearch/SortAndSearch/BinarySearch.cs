using System;
using System.Collections.Generic;
using System.Text;

namespace SortAndSearch
{
    class BinarySearch
    {
        //BINARY SEARCH
        //CODE FROM https://www.tutorialspoint.com/Binary-search-in-Chash
        //Binary searches compare the search element to the element in the middle of the sorted array. If the search is less than the middle element, the program only has to search the first half of the array. Otherwise, it searches the second half of the array.
        public static object BinarySearchDisplay(int[] arr, int key)
        {
            int minNum = 0;
            int maxNum = arr.Length - 1;
            int max;
            int min;

            while (minNum <= maxNum)
            {
                int mid = (minNum + maxNum) / 2;
                if (key == arr[mid])
                {
                    return ++mid;
                }
                else if (key < arr[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return "None";
        }
    }
}
