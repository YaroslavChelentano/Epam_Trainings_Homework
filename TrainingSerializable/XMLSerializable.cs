using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using Newtonsoft.Json;


namespace TrainingSerializable
{
    public class XMLSerializable : ISerializable
    {
        public void Writer(List <Car> cars)
        {
            Car lamba = new Car("Lamborgini Gallardo", 2003, 309);
            XmlSerializer writer = new XmlSerializer(typeof(Car));
            var path = Environment.CurrentDirectory + "//SerializationOverviewXML.xml";
            FileStream file = File.Create(path);
            writer.Serialize(file, lamba);
            file.Close();
        }

        public string Reader(List <Car> cars)
        {
            XmlSerializer reader = new XmlSerializer(typeof(Car));
            StreamReader file = new StreamReader(Environment.CurrentDirectory + "//SerializationOverviewXML.xml");
            Car lamba = (Car)reader.Deserialize(file);
            file.Close();
            return lamba.Model + lamba.Speed.ToString();
        }
    }
}
