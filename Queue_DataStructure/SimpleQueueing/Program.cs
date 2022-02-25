using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;


namespace SimpleQueueing
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue();

            string filepath = @"D:\C#\Queue_DataStructure\images\";
            string[] imageNames = { "image1", "image2", "image3", "image4" };

            string[] workDays = { "monday", "tuesday", "wednesday", "thursday", "friday" };

            List<string> myEnumerable = new List<string>();
            IDictionary<int, Bitmap> images = new Dictionary<int, Bitmap>();

            int count = 0;
            foreach(var image in imageNames)
            {
                string fullpath = $@"{filepath}\{image}.jpg";

                Bitmap newImage = (Bitmap)Image.FromFile(fullpath);
                queue.Enqueue(newImage);
                images.Add(count, newImage);
                count++;
            }
            
            

            foreach(var day in workDays)
            {
                myEnumerable.Add(day);
            }

            foreach(var day in workDays)
            {
                queue.Enqueue(day);
            }
            //foreach(var item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            Console.ReadLine();


        }

    }
}
