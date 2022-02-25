using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Parallel_sample
{
    public class MyCollection
    {
        public int CollectionId { get; set; }
        public string CollectionStatus { get; set; }
        public List<string> Collections { get; set; } 
    }
    class Program
    {
        // 0 -9 = 9 - 18
        static Thread thread1 = null;
        static int start = 0;
        static int end = 9;
        static int distance = 10;
        static int limit = 100;
        static int currenDistance = 0;
        static object sync = new object();

        static List<string> listOfString = new List<string>();
        static Dictionary<int, string> myDictionary = new Dictionary<int, string>();
        static Queue<Dictionary<int, string>> myQue = new Queue<Dictionary<int, string>>();

        private static void addSting()
        {
            List<string> stingList = new List<string>();
            for(int i = 0; i<=limit; i++)
            {
                int currentI = i;
                myDictionary.Add(i, i.ToString());
                if (i % distance == 0 || i == distance)
                {
                    thread1 = new Thread(new ThreadStart(() =>
                    {
                        int endLoop = i;
                        int startLoop = i - end;
                        displayDictionary(startLoop, endLoop);
                    }));
                    thread1.Name = "Dictionary";
                    thread1.IsBackground = true;
                    thread1.Start();
                }
            }
        }

        private static void addQueue(Dictionary<int, string> dict)
        {
            myQue.Enqueue(dict);
        }
        static void Main(string[] args)
        {
            addSting();
            Console.ReadLine();
        }

        private static void displayDictionary(int startLoop, int endLoop)
        {
            lock(sync)
            {
                if (endLoop != limit)
                {
                    for (int i = startLoop; i < endLoop; i++)
                    {
                        if (myDictionary[i] != null && i != limit)
                            Console.WriteLine(myDictionary[i].ToString());
                    }
                }
                Thread.Sleep(100);
            }
           

        }
    }
}
