using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

namespace SortAndSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            BubbleSort bubble = new BubbleSort();
            bubble.TimeArraySort(10000);
            Console.WriteLine("Arrays created. Check the bin/Debug/netcoreapp3.1 folder for the created text file.");
            bubble.TimeArraySort(80000);

            SelectionSort selection = new SelectionSort();
            selection.DoSelectionSort(80000);

            InsertionSort insertion = new InsertionSort();
            insertion.DoInsertionSort(80000);

            LinearSearch lin = new LinearSearch();
            lin.DoLinearSearch();
        }
    }
}
