using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    public class Employee : IComparable<Employee>, ICloneable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public int CompareTo(Employee other)
        {
            if (other == null) return 1;
            return Salary.CompareTo(other.Salary);
        }
        public object Clone() => new Employee { Name = this.Name, Salary = this.Salary };

        override public string ToString() => $"Name: {Name}, Salary: {Salary}";
    }
    public class Manager : Employee, IComparable<Manager>
    {
        public string Department { get; set; }
        public int CompareTo(Manager other) => base.CompareTo(other);
        public override string ToString() => $"{base.ToString()}, Department: {Department}";
    }
}
