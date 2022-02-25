using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Collections.Generic;


namespace ConcurrentQueue2
{
    class Program
    {
        static void Main(string[] args)
        {
            TestQueueRegular();
            Console.ReadLine();
        }


        private static void TestQueueRegular()
        {
            var phoneOrders = new ConcurrentQueue<string>();
            Task t1 = Task.Run(() => GetOrdersForConcurrent("Ma-aruf", phoneOrders));
            Task t2 = Task.Run(() => GetOrdersForConcurrent("Michael Jordan", phoneOrders));
            Task.WaitAll(t1, t2);
            string myOrder;
            foreach (var order in phoneOrders)
            {
                Console.WriteLine("Phone Order: {0}", order);
            }

            if (phoneOrders.TryDequeue(out myOrder))
            {
                Console.WriteLine($"{myOrder} has been removed");
            }

        }

        private static void GetOrdersForConcurrent(string custName, ConcurrentQueue<string> phoneOrders)
        {
            for (int i = 0; i < 3; i++)
            {
                string myOrder;
                Thread.Sleep(100);
                string order = string.Format("{0} needs {1} phones", custName, i + 5);
                phoneOrders.Enqueue(order);

            }
        }
    }
}
