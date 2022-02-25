using System;
using System.Xml;
using System.Text;
using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace xmlToJson
{
   
    class Program
    {


        static void Main(string[] args)
        {

            var myXML = new MyXml();
            string xml = myXML.xmlFile;

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xml);
            XmlNodeList xmlNodeList = xmlDoc.SelectNodes("Users/user");


            List<XmlModel> xmlList = new List<XmlModel>();
            
            foreach(XmlNode node in xmlNodeList)
            {
                XmlNodeList addList = node.SelectNodes("address");
                List<string> addressList = new List<string>();

                foreach (XmlNode addItem in addList)
                {
                    addressList.Add(addItem["streetname"].InnerText);
                    addressList.Add(addItem["city"].InnerText);
                    addressList.Add(addItem["pin"].InnerText);
                } 
                
                xmlList.Add(new XmlModel { 
                                            Id = int.Parse(node["id"].InnerText),
                                            Name = node["name"].InnerText,
                                            Gender = node["gender"].InnerText,
                                            Mobile = node["mobile"].InnerText,
                                            StreetName = addressList[0],
                                            City = addressList[1],
                                            Pin =  addressList[2]
                                
                });
                addressList.Clear();
            }
            
            foreach(var item in xmlList)
            {
                var person = $"ID: {item.Id}, " +
                             $"Name: {item.Name}, " +
                             $"Gender: {item.Gender}, " +
                             $"Mobile: {item.Mobile}, " +
                             $"Address: {item.StreetName} {item.City} {item.Pin}";

                Console.WriteLine(person);

            }
            //string json = JsonConvert.SerializeXmlNode(xmlDoc);
            //Console.WriteLine(json);
            Console.ReadKey();

        }

    }


    public class XmlModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Mobile { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string Pin { get; set; }

    }


    public class MyXml
    {
        public string xmlFile = @"  
                            <Users>  
                                <user>  
                                    <id>1</id>  
                                    <name>Emma watson</name>  
                                    <gender>Male</gender>
                                    <mobile>4557841155</mobile>  
                                    <address>  
                                        <streetname>Street1</streetname>
                                        <city>Pune</city>
                                        <pin>400043</pin>  
                                    </address>  
                                </user>  
                                <user>  
                                    <id>2</id>  
                                    <name>Fred ordan</name>  
                                    <gender>Female</gender>
                                    <mobile>4557841155</mobile>  
                                    <address>  
                                        <streetname>Street2</streetname>
                                        <city>Mumbai</city>
                                        <pin>400041</pin>  
                                    </address>  
                                </user>  
                                <user>  
                                    <id>3</id>  
                                    <name>John Cena</name>  
                                    <gender>Male</gender>
                                    <mobile>4557841155</mobile>  
                                    <address>  
                                        <streetname>Street3</streetname>
                                        <city>Pune</city>
                                        <pin>400045</pin>  
                                    </address>  
                                </user>  
                                <user>  
                                    <id>4</id>  
                                    <name>Wilson ordan</name>  
                                    <gender>Male</gender>
                                    <mobile>4557841155</mobile>  
                                    <address>  
                                        <streetname>Street4</streetname>
                                        <city>Pune</city>
                                        <pin>400043</pin>  
                                    </address>  
                                </user>  
                                <user>  
                                    <id>5</id>  
                                    <name>Robort John</name>  
                                    <gender>Male</gender>
                                    <mobile>4557841155</mobile>  
                                    <address>  
                                        <streetname>Street5</streetname>
                                        <city>Pune</city>
                                        <pin>400042</pin>  
                                    </address>  
                                </user>  
                            </Users>   ";
    }
}
