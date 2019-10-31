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
        private string path = Environment.CurrentDirectory + "//SerializationOverviewXML.xml";
        public void Writer(List <Car> cars)
        {
            XmlSerializer writer = new XmlSerializer(typeof(List<Car>));
            FileStream file = File.Create(path);
            writer.Serialize(file, cars);
            file.Close();
        }

        public List<Car> Reader()
        {
            XmlSerializer reader = new XmlSerializer(typeof(List<Car>));
            StreamReader file = new StreamReader(path);
            List<Car> cars = (List<Car>)reader.Deserialize(file);
            file.Close();
            return cars;
        }
    }
}
