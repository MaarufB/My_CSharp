using System;
using System.Threading;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Threading.Tasks;


namespace BlockingCollection_Producer_Consumer_Pattern_
{
    class Program
    {
        static void Main(string[] args)
        {
            BlockingCollection<int> bCollection = new BlockingCollection<int>(boundedCapacity: 10);

            Task producerThread = Task.Factory.StartNew(() =>
            {
                for(int i = 0; i < 10; i++)
                {
                    bCollection.Add(i);
                }
                bCollection.CompleteAdding();
            });

            Task consumerThread = Task.Factory.StartNew(() =>
            {
                while (!bCollection.IsCompleted)
                {
                    int item = bCollection.Take();
                    Console.WriteLine($"{item}");
                }
            });

            Task.WaitAll(producerThread, consumerThread);

            Console.ReadLine();
        }
    }
}
