using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace TrainingReflection
{
    public class AssemblyInfoConsoleOutput : IAssemblyInformation
    {
        public void ShowLibraries()
        {
            Console.WriteLine("Info about Assembly: ");
            foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
                Console.WriteLine(assembly);
        }
    }
}
