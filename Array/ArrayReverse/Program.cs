using System;

namespace ArrayReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of elements to store in an array: ");
            int numOfElem = Convert.ToInt32(Console.ReadLine());
            int[] myArray = new int[numOfElem];
            int tempNum;
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("Element {0} : ", i);
                tempNum = Convert.ToInt32(Console.ReadLine());
                myArray[i] = tempNum;
                Console.WriteLine(myArray[i]);
            }   

            for (int i = myArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(myArray[i]);
            }
        }
    }
}
