using System;
using System.Threading;


namespace threadLockMonitor
{
    class Program
    {

        static readonly object _object = new object();

        public static void PrintNumbers()
        {
            Boolean _lockTaken = false;
            Monitor.Enter(_object, ref _lockTaken);
            try
            {
                for(int i = 0;  i < 100; i++)
                {
                    Thread.Sleep(100);
                    Console.Write($"{i}, ");
                }
                Console.WriteLine();
            }
            catch(Exception ex)
            {
                var message = ex.ToString();
            }
            finally
            {
                if(_lockTaken)
                {
                    Monitor.Exit(_object);
                }
            }
        }

        static void TestLock()
        {
            lock(_object)
            {

                Console.WriteLine(Environment.TickCount);
            }
        }
        static void Main(string[] args)
        {
            Thread[] thread = new Thread[4];

            for(int i = 0; i < 4; i++)
            {
                thread[i] = new Thread(new ThreadStart(PrintNumbers));
                thread[i].Name = "Child" + i;
            }
            foreach(Thread t in thread)
            {
                t.Start();
            }

            Console.ReadLine();
        }
    }
}
