using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Training3
{
    public class FilesProvider : IOperationsWithFiles
    {
        public void GetFileAccordingToName(string fileName, IPrinter printer)
        {
            string[] directoryContainingFiles = Directory.GetFiles(@"c:\", $"{fileName}*.txt");
            foreach (var nameOfFile in directoryContainingFiles)
                printer.Print(nameOfFile);
        }
    }
}
