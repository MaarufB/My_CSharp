using System;
using System.Text;

namespace encoding
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "具有靜電產生裝置之影像輸入裝置"; // Unicode
            Encoding Windows1252 = Encoding.GetEncoding("Windows-1252");
            Encoding Utf8 = Encoding.UTF8;
            byte[] utf8Bytes = Utf8.GetBytes(s); // Unicode -> UTF-8
            string badDecode = Windows1252.GetString(utf8Bytes); // Mis-decode as Latin1
            //MessageBox.Show(badDecode,"Mis-decoded");  // Shows your garbage string.
            Console.WriteLine(badDecode, "Mis-decoded");
            string goodDecode = Utf8.GetString(utf8Bytes); // Correctly decode as UTF-8
            //MessageBox.Show(goodDecode, "Correctly decoded");
            Console.WriteLine(goodDecode, "Correctlu decoded");

            // Recovering from bad decode...
            byte[] originalBytes = Windows1252.GetBytes(badDecode);
            goodDecode = Utf8.GetString(originalBytes);
            //MessageBox.Show(goodDecode, "Re-decoded");
        
            Console.WriteLine(goodDecode, "Re-decoded");
        }
    }
}
