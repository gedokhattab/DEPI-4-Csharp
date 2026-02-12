using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Day06
{
    internal class TypeC : TypeA
    {
        public void Print()
        {
            //Console.WriteLine(F); // F is private in TypeA, so it can't be accessed in TypeC.
            //Console.WriteLine(G); // G is internal in TypeA, so it can be accessed in TypeC.
            Console.WriteLine(H); // H is public in TypeA, so it can be accessed in TypeC.
        }
    }
}
