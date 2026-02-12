using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;


namespace Day06
{
    struct Point
    {
        public int X { get; }
        public int Y { get; }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Point(int x)
        {
            X = x;
            Y = 0;
        }
        override public string ToString()
        {
            return $"(X value: {X}, Y value: {Y})";
        }
        // Struct is a value type, and it is stored in stack.
        // Class is a reference type, and it is stored in heap.
        // So Struct can't be inherited, but Class can be inherited. 

    }

    struct Employee
    {
        private string Name;
        private int EmpId;
        private decimal Salary;
        public Employee(string name, int id, decimal salary)
        {
            Name = name;
            EmpId = id;
            Salary = salary;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        override public string ToString()
        {
            return $"(Name: {Name}, Id: {EmpId}, Salary: {Salary})";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your choice (1 - 3): ");
            string choice = Console.ReadLine();

            // Mapping the choice to a method using a switch expression
            Action selectedProgram = choice switch
            {
                "1" => Program1,
                "2" => Program2,
                "3" => Program3,
                _ => () => Console.WriteLine("Invalid choice. Please select 1-3.")
            };

            // Execute the returned method
            selectedProgram();
        }

        #region Part01
        static void Program1()
        {
            TypeA A = new TypeA();
            //A.F = 1; //'TypeA.F' is inaccessible due to its protection level (private)
            //A.G = 2; //'TypeA.G' is inaccessible due to its protection level (internal)
            A.H = 3; // 'TypeA.H' is accessible because it is public

            A.print();

            //How do access modifiers impact the scope and visibility of a class member?
            // Access modifiers determine the accessibility of class members.
            // - Private: Accessible only within the class itself.
            // - Internal: Accessible within the same assembly.
            // - Public: Accessible from any code that can access the class.
        }

        static void Program2()
        {
            Point p1 = new Point(1, 2);
            Point p2 = new Point(3);
            Point p3 = new Point();
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());
            Console.WriteLine(p3.ToString());

            // Constructors are special methods used to initialize the fields of a struct when created.

            // Overriding methods allows you to provide a customized representation of an object which improve code readability.
        }

        static void Program3()
        {
            Employee emp1 = new Employee("Alice", 101, 50000);
            Console.WriteLine(emp1.ToString());
            emp1.SetName("Bob");
            Console.WriteLine($"Updated Name: {emp1.GetName()}");

            //Encapsulation protects an object's internal state from interference and misuse,
            //allowing developers to hide implementation details while exposing a controlled interface.
            //This promotes modularity, maintainability, and minimizes bugs,
            //enhancing security by preventing unauthorized access to sensitive data and ensuring consistent object usage.

        }
        #endregion

        #region Part02

        // 1- What is a copy constructor?

        // A copy constructor is a special constructor that creates a new object as a copy of an existing object.
        // It takes an instance of the same class as a parameter and initializes the new object with the values of the existing object.
        // Copy constructors are commonly used to create a new object that is a duplicate of an existing object,
        // especially when the class contains reference types or when a deep copy is needed.

        // ===================================
        // 2- What is Indexer, when used, as business mention cases u have to utilize it?

        // An indexer is a special type of property that allows the access of elements in a class or struct using array-like syntax.
        // It is defined using the 'this' keyword and can take parameters to specify the index.

        // Indexers are useful when you want to provide a way to access elements in a collection
        // or a custom data structure without exposing the underlying implementation.

        // examples of business cases for using indexers include:
        // - A class representing a collection of items, such as a list or an array,
        //   where you want to provide easy access to individual elements.
        // - A class representing a matrix or a grid, where you want to access elements using row and column indices.

        // examples:
        // public class MyCollection
        // {
        //     private int[] items = new int[100];
        //     public int this[int index]
        //     {
        //         get { return items[index]; }
        //         set { items[index] = value; }
        //     }
        // }

        // ===================================
        // 3- Summarize keywords we have learnt last lecture...

        // - namespace: A way to organize code and prevent naming conflicts by grouping related classes, structs, and other types together.
        // - struct: A value type that can contain data and methods, but cannot be inherited.
        // - class: A reference type that can contain data and methods, and can be inherited.

        // - field: A member that holds data or state of an object. It can be of any type and can have different access modifiers.
        // - property: A member that provides a flexible mechanism to read, write, or compute the value of a private field. It can have get and set accessors.
        // - value: the value used in a property setter or a field assignment, which is assigned to the corresponding field or property when the setter is called or the field is assigned.
        // - method: A member that contains code to perform a specific task. It can have parameters and return a value.

        // - private: An access modifier that restricts access to the member to within the class itself.
        // - protected: An access modifier that allows access to the member within the class and by derived class instances.
        // - private protected: An access modifier that allows access to the member within the class and by derived class instances that are in the same assembly.
        // - protected internal: An access modifier that allows access to the member within the same assembly or from derived classes in any assembly.
        // - internal: An access modifier that allows access to the member within the same assembly.
        // - public: An access modifier that allows access to the member from any code that can access the class.

        // - constructor: A special method used to initialize the fields of a struct or class when an instance is created.

        #endregion
    }
}
