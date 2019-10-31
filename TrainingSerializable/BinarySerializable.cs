using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace TrainingSerializable
{
    public class BinarySerializable : ISerializable
    {
        private string path = Environment.CurrentDirectory + "//SerializationOverviewBINARY.dat";
        private BinaryFormatter formatter = new BinaryFormatter();
        public void Writer(List<Car> cars)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, cars);
            }
        }

        public List<Car> Reader()
        {
            var cars = new List<Car>();
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                cars = (List<Car>)formatter.Deserialize(fs);
            }
            return cars;
        }
    }
}
