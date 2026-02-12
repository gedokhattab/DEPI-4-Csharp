using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class TypeA
    {
        private int F;
        internal int G;
        public int H;

        public void print()
        {
            Console.WriteLine($"F value: {F}, G value: {G}, H value: {H}");
        }
    }
}
