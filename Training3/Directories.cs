using System;
using System.IO;

namespace Training3
{
    public class Directories
    {
        DirectoryInfo dir = new DirectoryInfo(@"D:\Навчання");
        public static void DisplayDirectory()
        {
            Console.WriteLine(dir);
        }
    }
}
