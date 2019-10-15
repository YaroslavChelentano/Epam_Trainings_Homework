using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Training3
{
    public class FileLogger : ILogger
    {
        public readonly string filePath = @"logs.txt";
        public void Log(string message)
        {
            using (StreamWriter streamWriter = new StreamWriter(filePath))
            {
                streamWriter.WriteLine(message);
                streamWriter.Close();
            }
        }
    }
}
