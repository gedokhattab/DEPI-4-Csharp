using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08
{
    internal class Student
    {
        public int Id;
        public string Name ; 
        public double Grade;

        public Student(Student stud)
        {
            Id = stud.Id;
            Name = stud.Name;
            Grade = stud.Grade;

            // What is the primary purpose of a copy constructor in C#?
            // A copy constructor in C# is a special constructor that creates a new object as a copy of an existing object.
            // It is used to create a new instance of a class by copying the values of an existing instance.
        }
        public Student()
        {
            
        }

        public Student(int id, string name, double grade)
        {
            Id = id;
            Name = name;
            Grade = grade;
        }

    }
}
