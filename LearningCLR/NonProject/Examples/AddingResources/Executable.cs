using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace NonProject.Examples.AddingResources
{
    public class Executable
    {
        public static void Main()
        {
            try
            {
                var fileEndName = "textfile.txt";
                var currentAssembly = Assembly.GetExecutingAssembly();
                var resources = currentAssembly.GetManifestResourceNames();
                var resource = resources.SingleOrDefault(r => r.EndsWith(fileEndName, StringComparison.InvariantCultureIgnoreCase));
                if (resource == null)
                {
                    Console.WriteLine($"Could not find a resouce file ending with {resource}");
                }
                else
                {
                    Console.WriteLine($"Resource file found.");
                    string contents;
                    using (var sr = currentAssembly.GetManifestResourceStream(resource))
                    using (var reader = new StreamReader(sr))
                    {
                        contents = reader.ReadToEnd();
                    }
                    Console.WriteLine("File contents:");
                    Console.WriteLine(contents);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An exception occurred: {ex.Message}");
            }

            Console.WriteLine($"End of program...");
            Console.ReadKey();
        }
    }
}
