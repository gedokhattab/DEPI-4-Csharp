using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07
{
    internal class Car : IMovable
    {
        #region properties
        private int Id { get; set; }
        private string Brand { get; set; }
        private decimal Price { get; set; }
        #endregion

        #region constructors

        public Car()
        {
            
        }

        public Car(int _id)
        {
            Id = _id;
        }

        public Car(int _id, string _brand)
        {
            Id = _id;
            Brand = _brand;
        }
        public Car(int id, string brand, decimal price)
        {
            Id = id;
            Brand = brand;
            Price = price;
        }

        #endregion

        #region methods
        public void Move()
        {
            Console.WriteLine($"{Id} {Brand} is moving...");
        }

        #endregion

    }
}
