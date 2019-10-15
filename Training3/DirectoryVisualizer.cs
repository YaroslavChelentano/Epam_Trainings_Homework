using System;
using System.IO;

namespace Training3
{
    public class DirectoryVisualizer :  IOperationsWithFileSystem 
    {
        public string PathToDirectory { get; set; }
        public DirectoryVisualizer(string pathToDirectory= @"D:\Навчання\Epam")
        {
            PathToDirectory = pathToDirectory;
        }
        public void ShowDirectoryFiles(string targetDirectory, IPrinter printer)
        {
            string[] fileEntries = Directory.GetFiles(targetDirectory); // масив файлів директорії
            foreach (var fileName in fileEntries)
                printer.Print(fileName);

            // Рекурсивна функція для пошуку піддиректорій
            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (var subdirectory in subdirectoryEntries)
                ShowDirectoryFiles(subdirectory,printer);
        }
    }
}
