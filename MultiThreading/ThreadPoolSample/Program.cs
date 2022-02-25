using System;
using System.Threading;
using System.Diagnostics;


namespace ThreadPoolSample
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 100; i++)
            {
                MethodWithThread();
                MethodWithThreadPool();
            }

            Stopwatch sw = new Stopwatch();

            Console.WriteLine("Executing using Thread");
            sw.Start();
            MethodWithThread();
            sw.Stop();
            Console.WriteLine($"Time consumed by MethodWithThread is : {sw.ElapsedTicks.ToString()}");

            sw.Reset();

            Console.WriteLine("Exucuting using Thread Pool");
            sw.Start();
            MethodWithThreadPool();
            sw.Stop();
            Console.WriteLine($"Time consumed by MethodWithThreadPool is : {sw.ElapsedTicks.ToString()}");
            sw.Reset();
            Console.ReadLine();
        }

        public static void MethodWithThread()
        {
            for(int i = 0; i < 100; i++)
            {
                Thread thread = new Thread(Test);
            }
        }
        public static void MethodWithThreadPool()
        {
            for(int i = 0; i < 100; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(Test));
            }
        }

        public static void Test(object objec)
        {

        }
    }
}
