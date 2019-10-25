using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingSerializable
{
    public class JSONSerializable 
    {
        public  string Writer()
        {
            Car lamba = new Car();
            lamba.model = "Lamborgini Diablo";
            string json = JsonConvert.SerializeObject(lamba);
            return json;
        }

        public  string Reader(string json)
        {
            Car lamba = JsonConvert.DeserializeObject<Car>(json);
            return lamba.model;
        }
    }
}
