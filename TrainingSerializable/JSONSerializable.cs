﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingSerializable
{
    public class JSONSerializable : ISerializable
    {
        public void Writer(List<Car> cars)
        {
            Car lamba = new Car("Lamborgini Gallardo", 2003, 309);
            lamba.Model = "Lamborgini Diablo";
            string json = JsonConvert.SerializeObject(lamba);
        }

        public List<Car> Reader()
        {
            var cars = new List<Car>();
            //Car lamba = JsonConvert.DeserializeObject<Car>(json);
            //return lamba.Model;
            return cars;
        }
    }
}
