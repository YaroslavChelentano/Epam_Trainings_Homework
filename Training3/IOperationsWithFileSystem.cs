using System;
using System.Collections.Generic;
using System.Text;

namespace Training3
{
    interface IOperationsWithFileSystem
    {
        void DisplayFile(string path);
        void ShowDirectoryFiles(string targetDirectory);
    }
}
