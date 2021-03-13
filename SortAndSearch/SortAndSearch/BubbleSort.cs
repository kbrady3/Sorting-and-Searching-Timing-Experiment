using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SortAndSearch
{
    class BubbleSort
    {
        public TimeSpan TimeArraySort()
        {
            //BUBBLE SORT
            int[] b = new int[10000];
            Random rand = new Random();
            using StreamWriter file = new StreamWriter("UnsortedAndSortedArray.txt");

            file.WriteLine("Begin unsorted array");
            for (int i = 0; i < 10000; i++)
            {
                b[i] = rand.Next(1, 10000);
                file.WriteLine(b[i]);
            }
            file.WriteLine("End unsorted array");

            file.WriteLine("Begin sorted array");
            DateTime start = DateTime.Now;
            Array.Sort(b);
            DateTime end = DateTime.Now;
            TimeSpan difference = end - start;

            foreach (int y in b)
            {
                file.WriteLine(y);
            }
            file.WriteLine("End sorted array");

            return difference;
        }
    }
}
