using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TrainingSerializable
{
    public class JSONSerializable : ISerializable
    {
        private string path = Environment.CurrentDirectory + "//SerializationOverviewJSON.json";
        public void Writer(List<Car> cars)
        {
            string json = JsonConvert.SerializeObject(cars);
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                streamWriter.WriteLine(json);
                streamWriter.Close();
            }
        }

        public List<Car> Reader()
        {
            string json = File.ReadAllText(path, Encoding.UTF8);
            var cars = JsonConvert.DeserializeObject<List<Car>>(json);
            return cars;
        }
    }
}
