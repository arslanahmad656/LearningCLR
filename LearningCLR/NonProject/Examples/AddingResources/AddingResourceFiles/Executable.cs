using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using System.Reflection;

namespace NonProject.Examples.AddingResources.AddingResourceFiles
{
    class Executable
    {
        public static void Main(string[] args)
        {
            try
            {
                var executingAssembly = Assembly.GetExecutingAssembly().FullName;
                Console.WriteLine($"Assembly name: {executingAssembly}");
                var ass = Assembly.GetCallingAssembly().GetName().Name + ".Resources";
                var resourceManger = new ResourceManager(ass, Assembly.GetExecutingAssembly());
                var bmp = (System.Drawing.Bitmap)resourceManger.GetObject("Image1");
                var file = resourceManger.GetString("TextFile1");
                var str = resourceManger.GetString("StringRes");

                Console.WriteLine($"File contents: {file}");
                Console.WriteLine($"String contents: {str}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            Console.WriteLine("End of program...");
            Console.ReadKey(true);
        }
    }
}
