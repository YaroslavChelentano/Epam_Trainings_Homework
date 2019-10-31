using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingSerializable
{
    [Serializable]
    public class Car
    {
        public string Model { get; set; }
        public int YearOfManufacture { get; set; }
        public int Speed { get; set; }

        public Car() { }


        public Car(string model, int yearofmanufacture, int speed)
        {
            Model = model;
            YearOfManufacture = yearofmanufacture;
            Speed = speed;
        }
    }
}
