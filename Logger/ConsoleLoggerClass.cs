using System;
using System.Collections.Generic;
using System.Text;

namespace Logger
{
    public class ConsoleLoggerClass : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine(message);
        }

        public void ReadLog(string message)
        {
            throw new NotImplementedException("Not supported method");
        }
    }
}
