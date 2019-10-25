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
        public void Writer()
        {
            Car lamba = new Car();
            lamba.model = "Lamborgini Diablo";
            XmlSerializer writer = new XmlSerializer(typeof(Car));
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//SerializationOverview.xml";
            FileStream file = File.Create(path);
            writer.Serialize(file, lamba);
            file.Close();
        }

        public string Reader()
        {
            XmlSerializer reader = new XmlSerializer(typeof(Car));
            StreamReader file = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                + "//SerializationOverview.xml");
            Car lamba = (Car)reader.Deserialize(file);
            file.Close();
            return lamba.model;
        }
    }
}
