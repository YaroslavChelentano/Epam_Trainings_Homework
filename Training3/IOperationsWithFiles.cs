using System;
using System.Collections.Generic;
using System.Text;

namespace Training3
{
    public interface IOperationsWithFiles
    {
        void GetFileAccordingToName(string fileName, IPrinter printer);
    }
}
