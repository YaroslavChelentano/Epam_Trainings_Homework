using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingSerializable
{
    public interface ISerializable
    {
        void Writer(List <Car> cars);
        List<Car> Reader();
    }
}
