using System;
using System.Collections.Generic;
using System.Text;

namespace Logger
{
    public interface ILogger
    {
        void WriteLog(string message);
        void ReadLog(string message);
    }
}
