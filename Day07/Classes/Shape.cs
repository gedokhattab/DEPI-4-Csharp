using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07
{
    internal abstract class Shape
    {
        public virtual void Draw01()
        {
            Console.WriteLine("Drawing Shape");
        }

        public abstract decimal CalculateArea();
    }
}
