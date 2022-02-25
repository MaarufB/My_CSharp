using System;

namespace _2_7_next
{
    class Program
    {
            static int count_number_exist(int[] arr)
            {
                int countExist = 0;

                for(int i = 0; i <= arr.Length - 1; i++)
                {
                    if(arr[i] == 7 && arr[i + 1] == 7 )
                    {
                        countExist += 1;
                    }
                }
                return countExist;
            }

        static void Main(string[] args)
        {
            Console.WriteLine(count_number_exist(new int[] {1, 2, 3, 4, 5, 6, 7, 7, 8}));
            Console.WriteLine(count_number_exist(new int[] {2, 4, 6, 7, 7, 6, 7, 7, 8}));

        }
    }
}
