using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace select_sort
{
    public class SelectSortExercise
    {

        public void sortArray(int[] _arr)
        {
            int lenArray = _arr.Length;
          
            for (int i = 0; i < lenArray - 1; i++)
            {
                // This is for printing purpose
                Console.WriteLine($"This is iter {i}");
                

                int minimumIndx = i;
                for (int j = i + 1; j < lenArray; j++)
                {
                    if (_arr[j] < _arr[i])
                    {
                        minimumIndx = j;
                        var temp = _arr[minimumIndx];
                        _arr[minimumIndx] = _arr[i]; // swap
                        _arr[i] = temp;
                    }
                }
                for (int k = 0; k < lenArray; k++)
                {
                    Console.Write($"{_arr[k]} ");
                }

                Console.WriteLine("\n");

            }

            printArray(_arr);
        }

        public void printArray(int[] _arr)
        {
            Console.WriteLine("\nThis is the sorted list.");
            for (int i = 0; i < _arr.Length; i++)
            {
                Console.Write(_arr[i].ToString()+ " ");
            }
            Console.WriteLine("\n");
        }

    }
}
