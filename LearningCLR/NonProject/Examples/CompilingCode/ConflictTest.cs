using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonProject.Examples.CompilingCode
{
    public class ConflictTest
    {
        public static void Main()
        {
            var result = ConflictingAssemblies.ConflictingAssembly.Method();    // ambiguity
        }
    }
}
