using System;
using System.Threading;

namespace threadLock
{
    class Program
    {


        static readonly Object _object = new object();

        static void TestLock()
        {
            lock(_object)
            {
                Thread.Sleep(1000);
                Console.WriteLine(Environment.TickCount);
            }
        }
        
        static void Main(string[] args)
        {
               for(int i = 0; i < 10; i++)
            {
                Thread thread = new Thread(new ThreadStart(TestLock));
                thread.Start();
            }

            Console.ReadLine();
        }
    }
}
