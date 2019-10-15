using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Training3
{
    public class FilesProvider : IOperationsWithFiles
    {
        public string PathToDirectoryContainsFile { get; set; }
        public string FileName { get; set; }
        public FilesProvider(string pathToDirectoryContainsFile,string fileName)
        {
            PathToDirectoryContainsFile = pathToDirectoryContainsFile;
            FileName = fileName;
        }
        public void GetFileAccordingToName(IPrinter printer)
        {
            string[] directoryContainingFiles = Directory.GetFiles($@"{PathToDirectoryContainsFile}", 
                $"{FileName}*.txt");
            foreach (var nameOfFile in directoryContainingFiles)
                printer.Print(nameOfFile);
        }
    }
}
