using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace SortAndSearch
{
    class SelectionSort
    {
        public void DoSelectionSort(int maxSize)
        {
            DateTime start = DateTime.Now;

            //CODE FROM: https://www.tutorialspoint.com/selection-sort-program-in-chash
            //CODE HAS BEEN MODIFIED
            int[] arr = new int[maxSize];
            int n = maxSize;

            Random rand = new Random();

            for (int i = 0; i < maxSize; i++)
            {
                arr[i] = rand.Next(1, maxSize);
            }

            int temp, smallest;
            for (int i = 0; i < n; i++)
            {
                smallest = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[smallest])
                    {
                        smallest = j;
                    }
                }
                temp = arr[smallest];
                arr[smallest] = arr[i];
                arr[i] = temp;
            }

            DateTime end = DateTime.Now;
            TimeSpan diff = end - start;
            Console.WriteLine("Selection sort took " + diff + " to sort.");
        }
    }
}
