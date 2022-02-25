using System;
using System.Threading;


namespace Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            // Thread = an execution path of a program.
            //          We can use a multiple threads to perform different task of our program
            //          at the same time. Current thread running is "main" thread using System.Threading

            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";


            var thread1 = new Thread(() => 
            {
                CountDown("Thread1");
            });
            thread1.Start();

            var thread2 = new Thread(() => 
            {
                CountUp("Thread2");
            });
            thread2.Start();

            // Console.WriteLine($"{mainThread.Name} is Complete!");

            Console.ReadKey();
    

        }

        public static void CountDown(string name)
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine($"{ name } Timer #1 : { i } seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #1 is Complete!");
        }

        public static void CountUp(string name)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{ name } Timer #2 : { i } seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #2 is complete");
        }

    }
}
