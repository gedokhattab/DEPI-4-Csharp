using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08
{
    internal class Program
    {

        struct Account
        {
            private int Id;

            public int AccountId { get { return Id; } set { Id = value; } }
            private string Name;
            public string AccountName { get { return Name; } set { Name = value; } }
            private double Balance;
            public double AccountBalance { get { return Balance; } set { Balance = value; } }

        }
        static void Main(string[] args)
        {

            Console.Write("Enter your choice (1 - 5): ");
            string choice = Console.ReadLine();

            Action selectedProgram = choice switch
            {
                "1" => Program1,
                "2" => Program2,
                "3" => Program3,
                "4" => Program4,
                "5" => Program5,
                "6" => Program6,
                _ => () => Console.WriteLine("Invalid choice. Please select 1-5.")
            };

            selectedProgram();

        }

        #region Part01

        public static void Program1()
        {
            IVehicle vehicle = new Car();
            vehicle.StartEngine();
            vehicle.StopEngine();
            vehicle = new Bike();
            vehicle.StartEngine();
            vehicle.StopEngine();

            // Coding against an interface allows for greater flexibility and maintainability.
            // It enables the change of the underlying implementation without affecting the code that depends on it.
            // This promotes loose coupling and makes it easier to test and extend the application in the future.
        }
        public static void Program2()
        {
            Shape shape = new Circle(5);
            shape.Display();
            shape = new Rectangle(4, 6);
            shape.Display();

            // Using an abstract class allows us to define a common interface for all shapes while providing some shared functionality.
            // It promotes code reuse and makes it easier to manage and extend the hierarchy of shapes in the future.

            // Abstract classes are used for providing common implementations,
            // sharing non-static properties among derived classes,
            // and applying access modifiers to hide members.

            // They enable polymorphism by allowing method overrides while enforcing structure in class hierarchies.
            // In contrast, interfaces define contracts without implementation details, support multiple inheritance, but do not share code or state.
        }
        public static void Program3()
        {
            Product product1 = new Product { Id = 1, Name = "Laptop", Price = 999.99 };
            Product product2 = new Product { Id = 2, Name = "Smartphone", Price = 499.99 };
            Product product3 = new Product { Id = 3, Name = "Tablet", Price = 299.99 };

            Product[] arr = { product1, product2 };

            Sort(arr);

            // Implementing IComparable allows objects to be compared and sorted based on their natural ordering.
            // It provides a standard way to define how objects should be compared,
            // enabling the use of built-in sorting algorithms and collections that rely on comparison.
            // This promotes flexibility as it allows different types of objects to be sorted without needing to implement custom sorting logic for each type,
            // and it enables the use of polymorphism in sorting operations.
            // By implementing IComparable, we can easily sort collections of objects using their natural ordering,
            // which enhances code reusability and maintainability.

        }

        public static void Sort(Product[] List)
        {
            for (int i = 0; i < List.Length; i++)
            {
                for (int j = 0; j < List.Length - 1 - i; j++)
                {
                    if (List[j].CompareTo(List[j + 1]) == 1)
                    {
                        Product.Swap(ref List[j], ref List[j + 1]);
                    }
                }
            }
        }

        public static void Program4()
        {
            Student student1 = new Student(1, "Alice", 85.5);
            Student student2;

            student2 = student1; // Shallow Copy

            Student student3 = new Student(student1); // Deep Copy


            Console.WriteLine($"Student 1 Name {student1.Name} and Grade {student1.Grade}");
            Console.WriteLine(student1.GetHashCode());
            Console.WriteLine($"Student 2 Name {student2.Name} and Grade {student2.Grade}");
            Console.WriteLine(student2.GetHashCode() + "Shallow Copy");
            Console.WriteLine($"Student 3 Name {student3.Name} and Grade {student3.Grade}");
            Console.WriteLine(student3.GetHashCode() + "Deep Copy");
        }
        public static void Program5()
        {
            Robot myRobot = new Robot();
            myRobot.Walk(); // Output: Robot is Walking (Standard).

            IWalkable walkableRobot = myRobot;
            walkableRobot.Walk(); // Output: Robot is Walking (IWalkable).

            // Explicit interface implementation enables a class to implement multiple interfaces with members sharing the same name, avoiding naming conflicts.
            // By explicitly defining interface members, a class can provide distinct implementations for each interface,
            // allowing the caller to specify the desired implementation through type casting.
            // This approach enhances code organization and separation of concerns,
            // facilitating the implementation of multiple behaviors without ambiguity.
        }

        public static void Program6()
        {
            Account account = new Account();
            account.AccountId = 12345;
            account.AccountName = "John Doe";
            account.AccountBalance = 1000.50;
            Console.WriteLine($"Account ID: {account.AccountId}");
            Console.WriteLine($"Account Name: {account.AccountName}");
            Console.WriteLine($"Account Balance: {account.AccountBalance}");

            // What is the key difference between encapsulation in structs and classes?
            // The key difference between encapsulation in structs and classes is that structs are value types and classes are reference types.
            // In a struct, encapsulation is achieved by defining private fields and public properties or methods to access those fields.

            // Explicit interface implementation allows a class to implement multiple interfaces with members of the same name, preventing naming conflicts.
            // This method enables distinct implementations for each interface, which can be specified by type casting.
            // It improves code organization and separation of concerns, facilitating multiple behaviors without ambiguity.
        }
        public static void Program7()
        {
            Book book1 = new Book(); // Default constructor
            Book book2 = new Book("A Tale of two Cities"); // Parameterized constructor
            Book book3 = new Book("The Great Gatsby", "F. Scott Fitzgerald"); // Parameterized constructor with multiple parameters

            // Constructor overloading enhances class usability by allowing multiple ways to instantiate a class,
            // providing flexibility and convenience. It enables initialization of objects with varying data sets
            // for different use cases, simplifying object creation and improving code readability and maintainability
            // by letting developers select the most suitable constructor for their needs.


        }

        #endregion
    }
}
