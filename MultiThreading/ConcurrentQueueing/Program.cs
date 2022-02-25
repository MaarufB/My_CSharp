using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;


namespace ConcurrentQueueing
{
    class Program
    {

        static ConcurrentQueue<int> coll = new ConcurrentQueue<int>();

        static void Main(string[] args)
        {
            // Enumeration in ConcurrentQueue is thread-safe/
            Task t1 = Task.Factory.StartNew(() =>
            {
                for(int i = 0; i < 100; ++i)
                {
                    coll.Enqueue(i);
                    Thread.Sleep(100);
                }
            });

            Task t2 = Task.Factory.StartNew(() =>
            {
                Thread.Sleep(300);
                foreach(var item in coll)
                {
                    Console.WriteLine(item);
                    Thread.Sleep(150);
                }
            });

            try
            {
                Task.WaitAll(t1, t2);
            }
            catch(AggregateException ex)
            {
                Console.WriteLine(ex.Flatten().Message);
            }

            Console.ReadLine();
        }
    }
}



/// It provides an Enqueue method to add any item at the end of the queue. Enqueu takes the argument which data type matches with the type argument.
/// 
/// </summary>
/// <param name="args"></param>

//int item;
//ConcurrentQueue<int> coll = new ConcurrentQueue<int>();
//coll.Enqueue(1);
//coll.Enqueue(2);
//coll.Enqueue(3);
//coll.Enqueue(4);
//coll.Enqueue(5);
//coll.Enqueue(6);
//coll.Enqueue(7);
//coll.Enqueue(8);
//coll.Enqueue(9);
//coll.Enqueue(10);

//// To retrieve/remove single item
//// For retrieving items, we have two methods
//// 1. TryPeek
//// 2. TryDequeue
//// Difference between TryPeek and TryDequeu is that TryDequeue methods is removes an item from the list and TryPeek does not remove item from the list.

//// TryPeek() Method
//Console.WriteLine("TryPeek Method");
//coll.TryPeek(out item); // returns 1
//Console.WriteLine(item);
//coll.TryPeek(out item); // returns 1
//Console.WriteLine(item);

//Console.WriteLine("\n");
//Console.WriteLine("TryDequeue Method");
//coll.TryDequeue(out item); // returns 1
//Console.WriteLine(item);
//coll.TryDequeue(out item); // returns 2
//Console.WriteLine(item);


//Console.WriteLine("Combine");
//coll.TryPeek(out item); // returns 3
//Console.WriteLine(item);
//coll.TryDequeue(out item); // returns 3
//Console.WriteLine(item);
//coll.TryDequeue(out item); // returns 4
//Console.WriteLine(item);


//// Retrieve them All
//Console.WriteLine("\nRetrieve them all using foreach loop");
//foreach (var col in coll)
//{
//    Console.WriteLine(col);
//}
