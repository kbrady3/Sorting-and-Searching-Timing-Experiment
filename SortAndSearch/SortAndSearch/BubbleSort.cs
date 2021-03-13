using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SortAndSearch
{
    class BubbleSort
    {
        public void TimeArraySort(int arraySize)
        {
            //BUBBLE SORT
            int[] b = new int[arraySize];
            Random rand = new Random();
            using StreamWriter file = new StreamWriter("UnsortedAndSortedArray.txt");

            file.WriteLine("Begin unsorted array");
            for (int i = 0; i < arraySize; i++)
            {
                b[i] = rand.Next(1, arraySize);
                file.WriteLine(b[i]);
            }
            file.WriteLine("End unsorted array");

            file.WriteLine("Begin sorted array");
            DateTime start = DateTime.Now;

            //SORTS ARRAY
            //CODE FROM https://www.tutorialspoint.com/Bubble-Sort-program-in-Chash
            int temp;
            for (int j = 0; j <= b.Length - 2; j++)
            {
                for (int i = 0; i <= b.Length - 2; i++)
                {
                    if (b[i] > b[i + 1])
                    {
                        temp = b[i + 1];
                        b[i + 1] = b[i];
                        b[i] = temp;
                    }
                }
            }

            DateTime end = DateTime.Now;
            TimeSpan difference = end - start;

            foreach (int y in b)
            {
                file.WriteLine(y);
            }
            file.WriteLine("End sorted array");

            Console.WriteLine("Bubble array took " + difference + " to sort.");
        }
    }
}
