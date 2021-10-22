using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Reflection
{
    class Dynamic_Object
    {
        public Dynamic_Object() { }

        public Dynamic_Object(string Msg) { }

        public void First_Method() {
            Console.WriteLine("from first object");
        }

        public void Second_Method() {
            Console.WriteLine("from second object");

        }
    }

}
