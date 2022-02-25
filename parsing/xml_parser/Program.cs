using System;
using System.Xml;
using System.Data;
using System.IO;

namespace xml_parser
{
    class Program
    {
        private void readXmlFile(string file)
        {
            XmlTextReader xmlreader = new XmlTextReader(file);
            if (file != null || file != "")
            {
                while (xmlreader.Read())
                {
                    switch (xmlreader.NodeType)
                    {
                        case XmlNodeType.Element:
                            Console.Write("<" + xmlreader.Name);
                            Console.WriteLine(">");
                            break;
                        case XmlNodeType.Text:
                            Console.WriteLine(xmlreader.Value);
                            break;
                        case XmlNodeType.EndElement:
                            Console.Write("</" + xmlreader.Name);
                            Console.WriteLine(">");
                            break;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            XmlTextReader xmlreader = new XmlTextReader("test.xml");
            
            // This example here is just to show us on how to read the
            // basic outer part of xml tag
//            while (xmlreader.Read())
  //          {
                Console.WriteLine(xmlreader.Name);
    //        }
    
            p.readXmlFile("test.xml");

        }
    }
}
