using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Logger
{
    public class FileLoggerClass : ILogger
    {
        public IConfigurationRoot GetConfigurationOfJson()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile($"config.json")
                .Build();
            return config;
        }

        public string filePath { get; set; }
        //(@"D:\Навчання\Програмування\git\YaroslavChelentano\Epam_Trainings_Homework\Logger\logArchive.txt");
        public void WriteLog(string message)
        {
            Console.WriteLine(filePath);
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
