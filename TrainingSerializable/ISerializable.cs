using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingSerializable
{
    public interface ISerializable
    {
        void Writer();
        string Reader();
    }
}
