using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08
{
    internal class Product : IComparable
    {
        public int Id;
        public string Name;
        public double Price;

        public int CompareTo(object obj)
        {
            Product other = (Product)obj;

            if ((other?.Price ?? 0) < Price)
                return 1;
            else if ((other?.Price ?? 0) > Price)
                return -1;
            else
                return 0;

        }

        public static void Swap(ref Product a, ref Product b)
        {
            Product temp = a;
            a = b;
            b = temp;
        }
    }
}
