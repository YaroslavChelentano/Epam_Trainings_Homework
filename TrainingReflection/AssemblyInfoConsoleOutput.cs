using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.IO;

namespace TrainingReflection
{
    public class AssemblyInfoConsoleOutput : IAssemblyInformation
    {
        public void ShowLibraries()
        {
            foreach (var dllPath in Directory.EnumerateFiles(Environment.CurrentDirectory, "*.dll"))
            {
                try
                {
                    var assembly = Assembly.LoadFile(dllPath);
                    var types = assembly.GetTypes();
                    Console.WriteLine(assembly);
                }
                catch (System.BadImageFormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public void ShowClassesAndMethods()
        {
            List<Assembly> assemblies = new List<Assembly>();
            assemblies.Add(Assembly.Load(AssemblyName.GetAssemblyName("Logger.dll")));
            assemblies.Add(Assembly.Load(AssemblyName.GetAssemblyName("Training1.dll")));
            assemblies.Add(Assembly.Load(AssemblyName.GetAssemblyName("Training2.dll")));
            assemblies.Add(Assembly.Load(AssemblyName.GetAssemblyName("Training3.dll")));
            assemblies.Add(Assembly.Load(AssemblyName.GetAssemblyName("TrainingSerializable.dll")));
            List<Type[]> typesList = new List<Type[]>();
            foreach (Assembly assembly in assemblies)
                typesList.Add(assembly.GetTypes());
            foreach (Type[] typeArray in typesList)
                foreach(Type type in typeArray)
                    foreach (MemberInfo method in type.GetMethods())
                        Console.WriteLine($"ClassName: {type} , method: {method}");
        }
    }
}
