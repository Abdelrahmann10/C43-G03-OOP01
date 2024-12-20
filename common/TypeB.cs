using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common
{
    internal class TypeB
    {
        public TypeB()
        {
            TypeA obj = new TypeA();
            // obj.x = 10; (invalid)
            obj.y = 5;  // Valid
            obj.z = 10; // Valid
        }
    }
}
