using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08
{
    internal class Robot : IWalkable
    {
        // Standard Robot Method
        public void Walk()
        {
            Console.WriteLine("Robot is Walking (Standard).");
        }

        // Explicit Interface Implementation
        void IWalkable.Walk()
        {
            Console.WriteLine("Robot is Walking (IWalkable).");
        }
    }
}
