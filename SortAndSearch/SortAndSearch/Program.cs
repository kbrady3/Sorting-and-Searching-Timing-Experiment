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
            Console.WriteLine("Array took " + difference + " to sort.");
            Console.WriteLine("Arrays created. Check the bin/Debug/netcoreapp3.1 folder for the created text file.");

            //BigInteger[] c = new BigInteger[999999999999];
            List<BigInteger> c = new List<BigInteger>();

            for (int i = 0; i < 99999999; i++)
            {
                c.Add(i);
            }

            DateTime start2 = DateTime.Now;
            c.Sort();
            DateTime end2 = DateTime.Now;
            TimeSpan difference2 = end2 - start2;

            Console.WriteLine("Array #2 took " + difference2 + " to sort.");

            //LINEAR SEARCH
            //CODE FROM https://forgetcode.com/CSharp/1027-Linear-search-programming
            //Linear searches search from left to right, which is less efficient than other types of searches. However, linear is perhaps the easiest search method to understand.
            int[] a = new int[100];
            Console.WriteLine("Enter number of elements you want to hold in the array ?");
            string s = Console.ReadLine();
            int x = Int32.Parse(s);
            Console.WriteLine("-------------------------");
            Console.WriteLine("\n Enter array elements \n");
            for (int i = 0; i < x; i++)
            {
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
            Console.WriteLine("-------------------------");
            Console.WriteLine("Enter Search element\n");
            string s3 = Console.ReadLine();
            int x2 = Int32.Parse(s3);
            for (int i = 0; i < x; i++)
            {
                if (a[i] == x2)
                {
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Search successful");
                    Console.WriteLine("Element {0} found at location {1}\n", x2, i + 1);
                    return;
                }
            }
            Console.WriteLine("Search unsuccessful");
        }

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
