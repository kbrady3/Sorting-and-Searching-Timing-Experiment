using System;
using System.Collections.Generic;
using System.Text;

namespace SortAndSearch
{
    class InsertionSort
    {
        public void DoInsertionSort(int maxSize)
        {
            //CODE FROM https://www.tutorialspoint.com/insertion-sort-in-chash
            //CODE MODIFIED
            int[] arr = new int[maxSize];
            int n = maxSize, i, j, val, flag;

            DateTime start = DateTime.Now;
            for (i = 1; i < n; i++)
            {
                val = arr[i];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = val;
                    }
                    else flag = 1;
                }
            }
            DateTime end = DateTime.Now;

            TimeSpan diff = end - start;

            Console.WriteLine("Insertion sort took " + diff + " to sort.");
        }
    }
}
