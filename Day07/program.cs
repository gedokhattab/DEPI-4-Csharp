using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07
{
    public class Program
    {
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
                _ => () => Console.WriteLine("Invalid choice. Please select 1-5.")
            };

            selectedProgram();

        }

        #region Part01
        static void Program1()
        {
            Car car01 = new Car();
            Car car02 = new Car(10);
            Car car03 = new Car(11, "Toyta");
            Car car04 = new Car(12, "Lada", 5000);

            IMovable movableCar = new Car(13, "BMW", 10000);
            movableCar.Move();

            // In C#, when you define a custom constructor,
            // the compiler does not automatically generate the default parameterless constructor.
            // This is because the presence of a custom constructor indicates that you want
            // to control how instances of the class are created.

            // Using an interface reference to access implementing class methods allows for greater flexibility and abstraction in code.
            // It enables code writing that can work with any class that implements the interface, without needing to know the specific details of the class.
            // This promotes loose coupling and makes it easier to change or extend the functionality of code in the future.

        }

        static void Program2()
        {
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Sum(1, 2)); // Output: 3
            Console.WriteLine(calculator.Sum(1, 2, 3)); // Output: 6
            Console.WriteLine(calculator.Sum(1.5, 2.5)); // Output: 4.0

            // Method overloading allows you to use the same method name for different operations,
            // which can make the code more intuitive and easier to read.
            // It also promotes code reusability by allowing you to define multiple behaviors
            // for a method without needing to create separate method names for each variation.
        }

        static void Program3()
        {
            Parent parent = new Parent(1, 2);
            Child child = new Child(1, 2, 3);

            Console.WriteLine(parent);
            Console.WriteLine(child);

            Console.WriteLine(parent.Product());
            Console.WriteLine(child.Product());

            // Inheritance allows you to create a new class (Child) that is based on an existing class (Parent).
            // The Child class inherits the properties and methods of the Parent class,
            // which promotes code reusability and establishes a natural hierarchical relationship between classes.

            // The override keyword is used to provide a new implementation of a method that is inherited from a base class.
            // The new keyword is used to hide a member of the base class with a new implementation in the derived class.
            // When you use override, the method in the derived class will be called even when accessed through a base class reference.
            // When you use new, the method in the derived class will only be called when accessed through a derived class reference.

            //Why is ToString() often overridden in custom classes?
            // The ToString() method is often overridden in custom classes to provide a meaningful string representation of the object.
            // By default, the ToString() method returns the fully qualified name of the class,
            // which may not be informative for debugging or logging purposes.
        }

        static void Program4()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Draw();
            rectangle.Draw01();
            rectangle.PrintDetails();
            Console.WriteLine(rectangle.CalculateArea());

            Circle circle = new Circle();
            circle.PrintDetails();

            // You cannot create an instance of an interface directly because an interface is a contract that
            // defines a set of methods and properties that a class must implement.

            // Default implementations in interfaces allow you to provide a default behavior for methods in an interface.
            // This means that if a class implements the interface but does not provide its own implementation for a method,
            // it will use the default implementation provided in the interface. This can help reduce code duplication and
            // allow for easier maintenance and evolution of interfaces without breaking existing implementations.

            // A virtual method is a method that has an implementation in the base class and can be overridden in derived classes.
            // An abstract method is a method that does not have an implementation in the base class and must be overridden in derived classes.
            // Virtual methods provide a default behavior that can be changed by derived classes, while abstract methods require derived classes to provide their own implementation, ensuring that the method is implemented in all derived classes.

        }

        static void Program5()
        {
            File file = new File();
            file.Write("Hello, World!");
            Console.WriteLine(file.Read());

            // How does C# overcome the limitation of single inheritance with interfaces? 
            // C# supports multiple use of interfaces, which enables it to inherit behaviors from multiple sources.
            // This allows a class to have multiple sets of functionalities defined by different interfaces,
            // effectively overcoming the limitation of single inheritance.
            // A class can be designed to interact with different parts of a system and provide various
            // functionalities without being limited to a single inheritance hierarchy.

        }
        #endregion

        #region Part02
        // What is the difference between class and struct in C#? 

        // 1-   A class is a reference type, while a struct is a value type.
        // 2-   This means that when you create an instance of a class, it is allocated on the heap and accessed through a reference,
        //      while an instance of a struct is allocated on the stack and accessed directly.
        // 3-   Classes support inheritance and polymorphism, while structs do not.
        // 4-   Structs are typically used for small data structures that do not require inheritance or complex behavior,
        //      while classes are used for more complex objects that require features like inheritance and polymorphism.

        // If inheritance is relation between classes clarify other relations between classes....

        // Association: This is a relationship where one class uses another class.
        // For example, a Car class might have an association with an Engine class, where the Car class uses the Engine class to perform certain functions.
        // Aggregation: This is a special type of association where one class is a part of another class. For example, a Library class might have an aggregation relationship with a Book class, where the Library class contains multiple Book instances.
        // Composition: This is a stronger form of aggregation where the lifetime of the contained class is dependent on the lifetime of the containing class. For example, a House class might have a composition relationship with a Room class, where the Room instances are created and destroyed along with the House instance.
        // Dependency: This is a relationship where one class depends on another class to function. For example, a PaymentProcessor class might have a dependency on a Logger class to log payment transactions.
        // Interface Implementation: This is a relationship where a class implements an interface, which defines a contract that the class must adhere

        #endregion

    }
}
