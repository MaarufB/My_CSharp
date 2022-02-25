using System;

namespace ArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumNum = 0;
            int temp;
            int numElem;

            Console.Write("Input the number of elements: ");
            numElem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Element in an array: {0} ", numElem);
            Console.WriteLine("===============================");
            int[] myArray = new int[numElem];

            for (int i = 0; i <= myArray.Length - 1; i++)
            {
                Console.Write("Element in {0}: ", i);
                temp = Convert.ToInt32(Console.ReadLine());
                myArray[i] = temp;
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                sumNum += myArray[i];
            }
            Console.WriteLine("Sum of all elements are: {0} ", sumNum);

        }
    }
}
