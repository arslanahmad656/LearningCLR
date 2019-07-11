// this file is inteded to be a module. Compile it with /t:module

namespace CreatingMultifileAssembly
{
    public class TypeInModule1
    {
        public string Hello()
        {
            return "Hello";
        }
    }

    internal class InternalClassInModule1
    {
        public int HelloInternal()
        {
            return 1;
        }
    }
}
