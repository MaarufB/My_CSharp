using System;
using System.Threading;
using System.Collections.Generic;
using System.IO;


namespace QueueThread
{
    class Program
    {
        static void Main(string[] args)
        {
            object lockObj = new object();
            Queue<string> queue = new Queue<string>();
            Producer p = new Producer(queue);
            Consumer c1 = new Consumer(queue, lockObj, "c1");
            Consumer c2 = new Consumer(queue, lockObj, "c2");

            Thread t1 = new Thread(c1.consume);
            Thread t2 = new Thread(c2.consume);
            t1.Start();
            t2.Start();

            Thread t = new Thread(p.produce);
            t.Start();

            Console.ReadLine();

        }
    }

    public class Producer
    {
        Queue<string> queue;
        static int seq;

        public Producer(Queue<string> queue)
        {
            this.queue = queue;
        }


        public void produce()
        {
            while(seq++ < 1000) // just testing 15 minutes
            {
                string item = $"item {seq}";
                queue.Enqueue(item);
                Console.WriteLine($"Producing {item}");
            }
        }
    }

    public class Consumer
    {
        Queue<string> queue;
        Object lockObject;
        string name;

        public Consumer(Queue<string> queue, Object lockObject, string name)
        {
            this.queue = queue;
            this.lockObject = lockObject;
            this.name = name;
        }

        public void consume()
        {
            string item;
            Thread.Sleep(500);
            while (true)
            {
                lock(lockObject)
                {
                    if (queue.Count == 0)
                        continue;
                    item = queue.Dequeue();
                    Console.WriteLine($"{name} Consuming {item}");
                }
            }

        }
    }
}
