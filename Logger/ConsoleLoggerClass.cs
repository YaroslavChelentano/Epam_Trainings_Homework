using System;
using System.Collections.Generic;
using System.Text;

namespace Logger
{
    class ConsoleLoggerClass : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine(message);
        }

        public void ReadLog(string message)
        {

        }
    }
}
