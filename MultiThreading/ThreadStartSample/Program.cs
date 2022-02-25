using System;
using System.Threading;


namespace ThreadStartSample
{
    class Program
    {
        static private Thread _process;
        
        class GThread
        {
            public void Job()
            {
                for (int i = 0; i < 10; i++) Console.WriteLine($"Hello I am counting {i}");
            }
        }
        static void Main(string[] args)
        {
            var gThread = new GThread();
            ThisThread(gThread);

            Console.ReadLine();
        }

        static void ThisThread(GThread obj)
        {
            _process = new Thread(new ThreadStart(obj.Job));
            _process.Start();
        }
    }
}
