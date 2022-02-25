using System;

namespace split
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath1 = @"F:\EmailImport\rohan@yahoo.com_01-01-2014_05-05-22\Inv.trg";
            System.IO.FileInfo fif = new System.IO.FileInfo(filepath1);
            string folderdet = fif.Directory.Name;
            string[] arr1 = folderdet.Split('@');
            string myname = arr1[0];
            Console.WriteLine(myname);

            string filepath2 = @" F:\AutoImport - Folder\20141612\Inv.trg";
            System.IO.FileInfo fileinfo = new System.IO.FileInfo(filepath2);
            string foldername = fileinfo.Directory.Name;
            Console.WriteLine(foldername);
        }
    }
}
