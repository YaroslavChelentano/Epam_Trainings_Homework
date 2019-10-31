using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingSerializable
{
    public interface ISerializable
    {
        void Writer(List <Car> cars);
        string Reader(List <Car> cars);
    }
}
