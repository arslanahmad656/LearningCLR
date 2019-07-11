// This file is intended to be a library containing the self module and another module specified in Type1.cs
// Compile this by using /t:library and /addmodule:<other-module-name>

namespace CreatingMultifileAssembly
{
    public class Type2
    {
        public string HelloIn2()
        {
            return "Hello";
        }
    }
}
