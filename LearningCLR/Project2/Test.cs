// compile this file and view this type in ILDASM.EXE
// everything is converted to either a method or a field

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal sealed class Test
    {
        // Constructor
        public Test() { }

        // Finalizer
        ~Test() { }

        // Operator overload
        public static Boolean operator ==(Test t1, Test t2)
        {
            return true;
        }

        public static Boolean operator !=(Test t1, Test t2)
        {
            return false;
        }

        // An operator overload
        public static Test operator +(Test t1, Test t2) { return null; }

        // A property
        public String AProperty
        {
            get { return null; }
            set { }
        }
        // An indexer
        public String this[Int32 x]
        {
            get { return null; }
            set { }
        }

        // An event
        public event EventHandler AnEvent;
    }
}
