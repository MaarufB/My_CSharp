using System;
using System.Threading;
using System.IO;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace ConcurrentQueue_Producer_Consumer_Pattern_
{
    class Program
    {
        private readonly static ConcurrentQueue<int> _producerQ = new ConcurrentQueue<int>();
        private readonly static ConcurrentQueue<int> _consumerQ = new ConcurrentQueue<int>();
        private readonly static Producer _producer = new Producer(_producerQ);
        private readonly static Consumer _consumer = new Consumer(_producerQ, _consumerQ);
        private readonly static Consumer _consumer2 = new Consumer(_producerQ, _consumerQ);

       


        static void Main(string[] args)
        {

            _producer.RunProducer();
            _consumer.RunConsumer();

            _consumer2.RunConsumer();

            Thread _localThreadProducer;
            Thread _localThreadConsumer;

            _localThreadProducer = new Thread(new ThreadStart(_producer.AddElements))
            {
                Name = "Local Producer Thread",
                IsBackground = true
            };
            _localThreadProducer.Start();

            _localThreadConsumer = new Thread(new ThreadStart(_consumer.Print))
            {
                Name = "Local Consumer Thread",
                IsBackground = true
            };
            _localThreadConsumer.Start();

            Console.ReadLine();
        }
    }

    class Producer
    {
        private ConcurrentQueue<int> _concurrentQ;
        private Thread _thread;

        public Producer(ConcurrentQueue<int> concurrentQ)
        {
            _concurrentQ = concurrentQ;
        }

        public void RunProducer()
        {
            _thread = new Thread(new ThreadStart(AddElements))
            {
                Name = "Producer Thread",
                IsBackground = true
            };
            _thread.Start();
        }


        public void AddElements()
        {
            for(int i = 0; i<100000; i++)
            {
                _concurrentQ.Enqueue(i);
            }
        }
    }

    class Consumer
    {
        private ConcurrentQueue<int> _concurrentQ;
        private ConcurrentQueue<int> _consumerQ;
        private Thread _threadConsumer;
        
        public Consumer(ConcurrentQueue<int> concurrentQ, ConcurrentQueue<int> consumerQ)
        {
            _concurrentQ = concurrentQ;
            _consumerQ = consumerQ;
        }

        public void RunConsumer()
        {
            _threadConsumer = new Thread(new ThreadStart(Print))
            {
                Name = "Consumer Thread",
                IsBackground = true
            };
            _threadConsumer.Start(); 
        }

        public void Print()
        {

            while (true)
            {
                Thread.Sleep(5);
                var time = DateTime.Now.ToString("s");
                if (_concurrentQ.IsEmpty)
                    continue;
                int item;
                _concurrentQ.TryDequeue(out item);
                Console.WriteLine($"Consumer access item {item} from producer at time {time}");
            }



        }




    }
}
