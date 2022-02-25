using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bubble_sort
{
    class Program
    {
        static void bubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
                Console.WriteLine($"Bubble item: {i}");
                for (int j = 0; j < n - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        // swap temp and arr[i]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }

            foreach(var i in arr)
            {
                Console.Write($"{i} ");
            }
        }

        /* Prints the array */
        static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] arr = new int[] { 64, 34, 25, 12, 22, 11, 90 };
            bubbleSort(arr);
            Console.WriteLine("Sorted array");
            printArray(arr);
            Console.ReadLine();
        }
    }
}
