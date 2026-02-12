using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class TypeB : TypeA
    {
        public void Print()
        {
            //Console.WriteLine(F); // F is private in TypeA, so it can't be accessed in TypeB.
            Console.WriteLine(G); // G is internal in TypeA, so it can be accessed in TypeB.
            Console.WriteLine(H); // H is public in TypeA, so it can be accessed in TypeB.
        }
    }
}
