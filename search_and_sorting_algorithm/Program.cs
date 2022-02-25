using System;
using System.Collections;

namespace search_and_sorting_algorithm
{
    // Sharp Searching and Sorting Algorithm
    // Note : According to Wikipedia "Shell sort or Shell's method, is an in-place comparison sort.
    // It can be seen as either a generalization of sorting by exchange (bubble sort) or sorting by 
    // insertion (insertion sort). The method starts by sorting pairs of elements far apart from each other,
    // then progressively reducing the gap between elements to be compared. Starting with far apart elements can move 
    // some out-of-place elements into position faster than a simple nearest neighbour exchange."


    // An example run of Shellsort with gaps 5, 3 and 1 is shown below.
    // The first pass, 5-sorting, performs insertion sort on separate subarrays (a1, a6, a11), (a2, a7, a12), (a3, a8), (a4, a9), (a5, a10).
    // For instance, it changes the subarray (a1, a6, a11) from (62, 17, 25) to (17, 25, 62). The next pass, 3-sorting, performs insertion
    // sort on the subarrays (a1, a4, a7, a10), (a2, a5, a8, a11), (a3, a6, a9, a12). The last pass, 1-sorting, is an ordinary insertion sort 
    // of the entire array (a1,..., a12).
    //As the example illustrates, the subarrays that Shellsort operates on are initially short; later they are longer but almost ordered.
    // In both cases insertion sort works efficiently.
    //Shellsort is unstable: it may change the relative order of elements with equal values. It is an adaptive sorting algorithm in that
    // it executes faster when the input is partially sorted.
    
    class Program
    {
        static void shellShort(int[] arr, int array_size)
        {
            int i, j, inc, temp;
            inc = 3;

            while (inc > 0)
            {
                for (i = 0; i < array_size; i++)
                {
                    j = i;
                    temp = arr[i];
                    while ((j >= inc) && (arr[j - inc] > temp))
                    {
                        arr[j] = arr[j - inc];
                        j = j - inc;
                    }
                    arr[j] = temp;
                }

                if(inc/2 != 0)
                {
                    inc = inc / 2;
                }
                else if(inc == 1)
                {
                    inc = 0;
                }
                else
                {
                    inc = 1;
                }
            }
        }

        static void show_array_elements(int[] arr)
        {
            foreach(var element in arr)
            {
                Console.Write(element + " ");
            }
            Console.Write("\n");
        }

        static void Main(string[] args)
        {
            int[] arr = new int[] {5, -4, 11, 0, 18, 22, 67, 51, 6};
            int n;

            n = arr.Length;
            Console.WriteLine("Original Array Elements : ");
            show_array_elements(arr);
            shellShort(arr, n);
            Console.WriteLine("\nSorted Array Elements : ");
            show_array_elements(arr);
        }
    }
}
