using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double GetArea() => Width * Height;

        public Rectangle(double X, double Y)
        {
            Width = X;
            Height = Y;
        }
    }
}
