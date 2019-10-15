using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Logger
{
    public class FileLoggerClass : ILogger
    {
        public readonly string filePath = @"D:\Навчання\Програмування\git\YaroslavChelentano\Epam_Trainings_Homework\Training3\logs.txt";
        public void WriteLog(string message)
        {
            using (StreamWriter streamWriter = new StreamWriter(filePath))
            {
                streamWriter.WriteLine(message);
                streamWriter.Close();
            }
        }
        public void ReadLog(string message)
        {
            using (StreamReader sr = new StreamReader(filePath, Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
