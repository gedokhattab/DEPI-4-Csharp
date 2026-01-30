using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Problem 1
            Console.Write("Enter a number (Parse / Convert): ");
            string input1 = Console.ReadLine();
            try
            {
                int parsedValue = int.Parse(input1);
                int convertedValue = Convert.ToInt32(input1);

                Console.WriteLine($"int.Parse result: {parsedValue}");
                Console.WriteLine($"Convert.ToInt32 result: {convertedValue}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }

            // int.Parse => throws an exception if the input is not a valid integer.
            // Convert.ToInt32 => handle null values by returning 0.


            #endregion

            Console.WriteLine("----------------------------------");

            #region Problem 2
            Console.Write("Enter a number (TryParse): ");
            string input2 = Console.ReadLine();

            if (int.TryParse(input2, out int tryParseResult))
            {
                Console.WriteLine($"Valid integer: {tryParseResult}");
            }
            else
            {
                Console.WriteLine("Invalid integer input.");
            }

            // int.TryParse => No exception for invalid input; 
            // int.TryParse => returns a boolean indicating success or failure.


            #endregion

            Console.WriteLine("----------------------------------");

            #region Problem 3
            object obj;

            obj = 10;
            Console.WriteLine($"int hash: {obj.GetHashCode()}");

            obj = "Hello";
            Console.WriteLine($"string hash: {obj.GetHashCode()}");

            obj = 10.5;
            Console.WriteLine($"double hash: {obj.GetHashCode()}");

            //  Helps quickly locate objects in hash-based collections like dictionaries and hash sets.


            #endregion

            Console.WriteLine("----------------------------------");

            #region Problem 4
            Box box1 = new Box();
            box1.Value = 10;

            Box box2 = box1;
            box1.Value = 50;

            Console.WriteLine($"Value from second reference: {box2.Value}");

            // Multiple references can point to the same memory location.
            // Changes through one reference affect all others.
            // Critical for understanding bugs in OOP.

            #endregion

            Console.WriteLine("----------------------------------");

            #region Problem 5
            string s = "Hello";
            Console.WriteLine($"Before modification hash: {s.GetHashCode()}");

            s += " Hi Gedo";
            Console.WriteLine($"After modification hash: {s.GetHashCode()}");

            // Strings are immutable; modifying a string creates a new instance.
            // Strings are based on arrays of characters stored in heap memory.
            // Since arrays are of fixed size, modifying a string results in a new array allocation.

            #endregion

            Console.WriteLine("----------------------------------");

            #region Problem 6
            StringBuilder sb1 = new StringBuilder("Hi Gedo");

            Console.WriteLine($"Before append hash: {sb1.GetHashCode()}");

            sb1.Append(" Welcome");
            Console.WriteLine($"After append hash: {sb1.GetHashCode()}");

            // StringBuilder is mutable; modifications do not create new instances.
            // StringBuilder uses a dynamic array that can resize as needed, allowing efficient modifications.
            // Modifies internal buffer without creating new objects.

            // StringBuilder avoids repeated memory allocation.
            // Less garbage collection overhead.
            // Designed for mutation.

            #endregion

            Console.WriteLine("----------------------------------");

            #region Problem 7
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Sum is " + (a + b));
            Console.WriteLine(string.Format("Sum is {0}", a + b));
            Console.WriteLine($"Sum is {a + b}");

            // String Interpolation ($) => More readable and concise for embedding expressions directly within string literals.

            #endregion

            Console.WriteLine("----------------------------------");

            #region Problem 8
            StringBuilder sb2 = new StringBuilder("Hi Gedo");

            sb2.Append(" Welcome");
            sb2.Replace("Gedo", "Khattab");
            sb2.Insert(3, "Hello ");
            sb2.Remove(0, 3);

            Console.WriteLine(sb2.ToString());

            // Ideal for scenarios with frequent string manipulations.
            // Mutable.
            // Single memory buffer.
            // Built specifically for heavy text manipulation.

            #endregion
        }
        class Box
        {
            public int Value;
        }
    }
}
