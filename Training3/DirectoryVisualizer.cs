using System;
using System.IO;

namespace Training3
{
    public class DirectoryVisualizer
    {
        public string PathToDirectory { get; set; }
        public DirectoryVisualizer(string pathToDirectory= @"D:\Навчання\Epam")
        {
            PathToDirectory = pathToDirectory;
        }
        public void ShowDirectoryFiles(string targetDirectory)
        {
            string[] fileEntries = Directory.GetFiles(targetDirectory); // масив файлів директорії
            foreach (string fileName in fileEntries)
                DisplayFile(fileName);

            // Рекурсивна функція для пошуку піддиректорій
            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
                ShowDirectoryFiles(subdirectory);
        }

        public static void DisplayFile(string path)
        {
            Console.WriteLine("Founded file '{0}'.", path); // допоміжна логіка для пошуку файлу
        }
    }
}
