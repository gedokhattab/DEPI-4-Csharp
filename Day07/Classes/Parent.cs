using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07
{
    internal class Parent
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Parent(int x, int y)
        {
            X = x;
            Y = y;
        }

        public virtual int Product()
        {
            return X * Y;
        }

        override public string ToString()
        {
            return $"X: {X}, Y: {Y}";
        }
    }
}
