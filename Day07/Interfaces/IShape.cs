using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07
{
    internal interface IShape
    {
        public int Area { get; }

        public void Draw();

        public void PrintDetails();
    }
}
