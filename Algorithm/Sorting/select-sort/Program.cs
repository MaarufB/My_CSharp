using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace select_sort
{
    // SELECTION SORT
    // The selection sort algorithm sorts an array by repeatedly finding the minimum element (considering ascending order) from unsorted part and putting it at the beginning.
    // The algorithm maintains two subarrays in in a given array.
    // 1. The subarray which is already sorted.
    // 2. Remaining subarray which is unsorted.

    // In every iteration of selection sort, the minimum element (considering ascending order)
    // from the unsorted subarray is picked and moved to the sorted subarray.

   
    public class Program
    {

        static void sort(int[] arr)
        {
            int n = arr.Length;
            // one by one move boundary of unsorted subarray
            for (int i = 0; i < n - 1; i++)
            {
                // find the minimum element in unsorted array
                int minIndx = i;
                for(int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndx]) minIndx = j;

                    //Console.WriteLine($"value of i:{i}, value of j:{j}");
                    // Swap the found minimum element with the first element
                    int temp = arr[minIndx];
                    arr[minIndx] = arr[i]; // swap the minIdx element to the previous element

                    arr[i] = temp;
                }
            }
        }

        static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write($"{arr[i]} ");
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            int[] arr = new int[] { 64, 25, 12, 22, 11 };

            int[] testElement = { 4, 1, 3, 9, 7 };

            var obj = new SelectSortExercise();
            obj.sortArray(testElement);
            obj.sortArray(arr);
                  

            sort(arr);

            Console.WriteLine("Sorted array");

            //printArray(arr);

            Console.ReadLine();

        }


    }

    //static class ClassObj
    //{
    //    SelectSortExercise obj = SelectSortExercise();
    //}
}
