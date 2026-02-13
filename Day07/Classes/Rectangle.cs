using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07
{
    internal class Rectangle : Shape, IShape
    {
        public int Area { get; }

        decimal Length;
        decimal Width;

        public Rectangle()
        {
        }

        public Rectangle(decimal _Length, decimal _Width)
        {
            Length = _Length;
            Width = _Width;
        }

        public void Draw()
        {
            Console.WriteLine("Drawing a rectangle...");
        }
        public void PrintDetails()
        {
            Console.WriteLine($"Rectangle with area: {Area}");
        }

        public override void Draw01()
        {
            Console.WriteLine("Drawing a Rectangle... ");
        }
        public override decimal CalculateArea()
        {
            return Length * Width;
        }
    }
}
