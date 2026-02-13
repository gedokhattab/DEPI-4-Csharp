using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07
{
    internal class Circle : IShape
    {
        public int Area { get; }
        public int Draw()
        {
            Console.WriteLine("Drawing a circle...");
            return Area;
        }
        public void PrintDetails()
        {
            Console.WriteLine($"Circle with area: {Area}");
        }
    }
}
