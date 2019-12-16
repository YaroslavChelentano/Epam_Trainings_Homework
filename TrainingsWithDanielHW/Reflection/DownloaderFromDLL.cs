using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace TrainingsWithDanielHW.Reflection
{
    public static class DownloaderFromDLL
    {
        public static List<Type> listOfTypes = new List<Type>();
        public static string path { get; set; }
        public static void Load()
        {
            listOfTypes.Clear();
            if (!Directory.Exists(path))
                return;
            DirectoryInfo di = new DirectoryInfo(path);
            FileInfo[] files = di.GetFiles("*.dll");
            foreach (var file in files)
            {
                Assembly newAssembly = Assembly.LoadFile(file.FullName);
                Type[] types = newAssembly.GetExportedTypes();
                foreach (var type in types)
                {
                    //If Type is a class and implements the IntegrationInterface interface
                    if (type.IsClass && (type.GetInterface(typeof(IntegrationInterface).FullName) != null))
                        listOfTypes.Add(type);
                }
            }
        }
        public static void Invoke()
        {
            foreach (var integrationType in listOfTypes)
            {
                var ctor = integrationType.GetConstructor(new Type[] { });
                var integration = ctor.Invoke(new object[] { }) as IntegrationInterface;
                //call methods on integration
            }
        }
    }
}
