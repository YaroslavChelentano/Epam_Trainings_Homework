using System;
using System.Collections.Generic;
using System.Text;

namespace Training3
{
    public interface IOperationsWithFileSystem
    {
        void ShowDirectoryFiles(string targetDirectory, IPrinter printer);
    }
}
