using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07
{
    internal class Child : Parent
    {
        public int Z { get; set; }
        public Child(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }
        override public int Product()
        {
            return base.Product() * Z;
        }

        override public string ToString()
        {
            return $"X: {X}, Y: {Y}, Z: {Z}";
        }
    }
}
