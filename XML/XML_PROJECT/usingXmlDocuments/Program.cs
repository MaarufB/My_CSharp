using System;
using System.Text;
using System.Xml;


namespace usingXmlDocuments
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("http://www.ecb.int/stats/eurofxref/eurofxref-daily.xml");
            
            foreach (XmlNode xmlNode in xmlDoc.DocumentElement.ChildNodes[2].ChildNodes[0].ChildNodes)
            {
                Console.WriteLine(xmlNode.ChildNodes);
                Console.WriteLine(xmlNode.Attributes["currency"].Value + ": " + xmlNode.Attributes["rate"].Value);
            }

            Console.ReadKey();
        }
    }
}
