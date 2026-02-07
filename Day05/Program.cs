using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your choice (1 - 16): ");
            string choice = Console.ReadLine();

            // Mapping the choice to a method using a switch expression
            Action selectedProgram = choice switch
            {
                "1" => Program1,
                "2" => TestDefensiveCode,
                "3" => Program3,
                "4" => Program4,
                "5" => Program5,
                "6" => Program6,
                "7" => Program7,
                "8" => Program8,
                "9" => Program9,
                "10" => Program10,
                "11" => Program11,
                "12" => Program12,
                "13" => Program13,
                "14" => Program14,
                "15" => Program15,
                "16" => Program16,
                _ => () => Console.WriteLine("Invalid choice. Please select 1-16.")
            };

            // Execute the returned method
            selectedProgram();
        }

        #region Part01

        public static void Program1()
        {
            int num1 = 0, num2 = 0, num3 = 0;
            try
            {
                do
                {
                    Console.WriteLine("Enter first integer:");
                    bool flag1 = int.TryParse(Console.ReadLine(), out num1);
                    Console.WriteLine("Enter second integer:");
                    bool flag2 = int.TryParse(Console.ReadLine(), out num2);
                } while (num2 == 0);
                num3= num1 / num2;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine($"The result of {num1} divided by {num2} is: {num3}");
                Console.WriteLine("Operation completed.");
            }
            // The finally block executes regardless of whether an exception was thrown or caught
            // ensuring that the final output is always displayed.
        }

        public static void TestDefensiveCode()
        {
            int X, Y, Z;
            do
            {
                Console.WriteLine("Enter first Number : ");
            }
            while (!int.TryParse(Console.ReadLine(), out X) || X < 0);
            do
            {
                Console.WriteLine("Enter Second Number : ");
            }
            while (!int.TryParse(Console.ReadLine(), out Y) || Y <= 1);

            Z = X / Y;
            Console.WriteLine($"The result of dividing {X} by {Y} is {Z}");

            // int.TryParse() returns a boolean indicating success or failure of parsing.
            // allowing for graceful handling of invalid input without throwing exceptions.
            // whereas int.Parse() throws an exception if the input is not a valid integer.
            // which can lead to program crashes if not properly handled.
        }

        public static void Program3()
        {
            int? num = null;
            int res = num ?? 10; // null-coalescing operator

            // HasValue: check if the variable holds value (Returns true/false)
            // Value: returns the value itself (Crashes if the box is empty)
            // Value throws an InvalidOperationException.
        }

        public static void Program4()
        {
            try
            {
                int[] arr = new int[5];
                arr[6] = 57;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void Program5()
        {
            int[,] arr = new int[3, 3];
            bool flag;
            Console.WriteLine("Enter Matrix Values [3 x 3]:");
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    flag= int.TryParse(Console.ReadLine(), out arr[i, j]);

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int RowSum = 0;
                int ColumnSum = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    RowSum += arr[i, j];
                    ColumnSum += arr[j, i];
                }
                Console.WriteLine($"Sum for row number -> \t\t {i+1} is {RowSum}");
                Console.WriteLine($"Sum for column number -> \t\t {i+1} is {ColumnSum}");
            }

            // GetLength() retrieves the number of elements in a specific "direction" or axis (starting at index 0).
        }

        public static void Program6()
        {
            int[][] jaggedArray = new int[3][];

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.Write($"Enter number of elements for row {i + 1}: ");
                bool flag = int.TryParse(Console.ReadLine(), out int size);
                jaggedArray[i] = new int[size];

                for (int j = 0; j < size; j++)
                {
                    Console.Write($"\n  Enter value for row {i}, column {j}: ");
                    bool flag2 = int.TryParse(Console.ReadLine(), out jaggedArray[i][j]);
                }
            }

            Console.WriteLine("\n\t\t Array Values \n");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.Write($"Row {i + 1}: ");
                foreach (int value in jaggedArray[i])
                {
                    Console.Write(value + " ");
                }
                Console.WriteLine();
            }
            // Rectangular arrays (int[,]) store all elements in one contiguous block of memory,
            // making access slightly faster because element locations are computed directly.
            // Jagged arrays (int[][]) are arrays of separate arrays stored in different memory locations,
            // offering flexibility in row sizes at the cost of an extra memory lookup per access.
        }

        public static void Program7()
        {
            string? userInput;

            Console.WriteLine("Type something (or leave it empty to keep it null):");
            string? input = Console.ReadLine();

            userInput = string.IsNullOrWhiteSpace(input) ? null : input;

            Console.WriteLine($"Length of your input: {userInput!.Length}");

            // Nullable reference types allow you to explicitly mark variables that can be null to avoid unexpected crashes.
            // This helps the compiler catch potential null-pointer errors during development rather than at runtime.
        }

        public static void Program8()
        {
            int number = 10;
            object boxedNumber = number;
            // Boxing: converting a value type (int) to an object type (object)
            // Safe - Valid - but slow because it requires a data copy from the stack to the heap.
            try
            {
                int unboxed = (int)boxedNumber;
                Console.WriteLine($"Successfully unboxed: {unboxed}");
                // Unboxing: converting the object back to a value type (int)
                // Safe - Valid - but slow because it requires a type check and a data copy from the heap to the stack.

                Console.WriteLine("Attempting invalid cast...");
                double invalidUnbox = (double)boxedNumber;
                // Unsafe - Invalid - and will throw an exception at runtime due to the type mismatch.
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine($"Unboxing Error: {ex.Message}");
            }
        }

        public static void Program9()
        {
            int X, Y;

            Console.WriteLine("Enter two numbers");
            bool flag1 = int.TryParse(Console.ReadLine(), out X);
            bool flag2 = int.TryParse(Console.ReadLine(), out Y);
            SumAndMultiply(X, Y, out int resultSum, out int resultProduct);

            // Out parameters allow a method to return multiple values by passing variables that will be assigned within the method.
            // The Out doesn't need to be assigned a value before being passed into the method.
            // but the method must assign a value before it returns.
            // Initialization is mandatory to ensure the caller receives valid data instead of uninitialized "garbage" memory.

            Console.WriteLine($"Sum: {resultSum}");
            Console.WriteLine($"Product: {resultProduct}");

            RepeatString("Hello, World!", X);
            // Optional parameters must appear last so the compiler can correctly map your arguments
            // to the right variables by their position.

            int total = SumArray(1, 2, 3, 4, 5);
            Console.WriteLine($"Total Sum: {total}");

            int[] sumarr = new int[] { 1, 2, 3, 4, 5 };
            total = SumArray(sumarr);
            Console.WriteLine($"Total Sum from array: {total}");
            // Three rules for using params:
            // 1- Only One: You can only have one params keyword per method.
            // 2- Last Place: The params parameter must be the very last one in the parameter list.
            // 3- Single Dimension: It must be a single-dimensional array(e.g., int[], not int[,]).
        }

        public static void SumAndMultiply(int X, int Y, out int sum, out int product)
        {
            sum = X + Y;
            product = X * Y;
        }

        public static void RepeatString(string message, int count = 5)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(message);
            }
        }

        public static int SumArray(params int[] Numbers)
        {
            int sum = 0;
            foreach (int num in Numbers)
                sum += num;
            return sum;
        }

        public static void Program10()
        {
            int[]? arr = new int[5];
            for (int i = 0; i < (arr?.Length ?? 0); i++)
            {
                Console.WriteLine($"Enter value for index {i}:");
                bool flag = int.TryParse(Console.ReadLine(), out arr[i]);
            }
            Console.WriteLine("You entered:");
            for (int i = 0; i < (arr?.Length ?? 0); i++)
                Console.WriteLine(arr[i]);

            // Null-Coalescing Operator(??): Returns the left-hand operand if not null; otherwise, it returns the right-hand operand.
            // res = value?? defaultValue; // If value is not null, res gets value; if value is null, res gets defaultValue.
            // Null-Conditional Operator(?.): Returns null if the operand is null, preventing errors when accessing members like .Length.
            // length = arr?.Length ?? 0; // If arr is not null, length gets arr.Length; if arr is null, length gets 0.
        }

        public static void Program11()
        {
            Console.Write("Enter a day of the week: ");
            string day = Console.ReadLine();

            // Switch expression: compact, returns a value directly
            int dayNumber = day.ToLower() switch
            {
                "monday" => 1,
                "tuesday" => 2,
                "wednesday" => 3,
                "thursday" => 4,
                "friday" => 5,
                "saturday" => 6,
                "sunday" => 7,
                _ => 0 // The discard symbol '_' handles the default case
            };
            // The switch expression is more concise and readable than a traditional switch statement.
            // switch is better than if-else chains for multiple discrete values, improving readability and maintainability,
            // by clearly showing the mapping between cases and results.

            if (dayNumber > 0)
                Console.WriteLine($"{day} is day number {dayNumber}.");
            else
                Console.WriteLine("Invalid day entered.");
        }

        #endregion

        #region Part02

        public static void Program12()
        {
            int num1 = 0;
            bool flag;
            Console.WriteLine("Enter a positive Integer: ");
            do
            {
                flag = int.TryParse(Console.ReadLine(), out num1);
                if (flag)
                    Console.WriteLine($"You entered: {num1}");
                else
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
            } while (!flag || num1 < 1);

            PrintSequence(num1);

            PrintMultiplicationTable(num1);

            PrintEvenSequnce(num1);
        }

        private static void PrintEvenSequnce(int num1)
        {
            Console.WriteLine("\nPrinting the sequence of even numbers from 1 to num1");
            for (int i = 2; i <= num1; i+=2)
                Console.Write(i + "\t");
        }

        private static void PrintMultiplicationTable(int num1)
        {
            Console.WriteLine("\nPrinting the multiplication table for num1");
            for (int i = 1; i<=12; i++)
                Console.Write(i*num1 + "\t");
        }

        private static void PrintSequence(int num1)
        {
            Console.WriteLine("\nPrinting the sequence of numbers from 1 to num1");
            for (int i = 1; i <= num1; i++)
                Console.Write(i + "\t");
        }

        public static void Program13()
        {
            int num1 ,num2;
            bool flag, flag2;
            Console.WriteLine("Enter two numbers: ");
            do
            {
                flag = int.TryParse(Console.ReadLine(), out num1);
                flag2 = int.TryParse(Console.ReadLine(), out num2);
            } while (!flag || !flag2);

            int res = num1;
            for (int i = 1; i < num2; i++)
                res *= num1;
            Console.WriteLine($"The Result of {num1} power {num2} is {res}");

        }

        public static void Program14()
        {
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();
            for (int i = input.Length - 1; i>=0; i--) 
                Console.Write(input[i]); 
        }

        public static void Program15()
        {
            int num1;
            bool flag;

            Console.WriteLine("Enter a number: ");
            do
                flag = int.TryParse(Console.ReadLine(), out num1);
            while (!flag);

            int res = num1;
            int reversedNum = 0;
            while (res > 0)
            {
                int lastDigit = res % 10;
                reversedNum = (reversedNum * 10) + lastDigit;
                res /= 10;
            }

            Console.WriteLine($"The reversed number is: {reversedNum}");
        }

        public static void Program16() 
        {
            Console.WriteLine("Enter a sentence: ");
            string input = Console.ReadLine();
            string[] words = input.Split(' ');
            Array.Reverse(words);
            string reversedSentence = string.Join(" ", words);
            Console.WriteLine($"Reversed sentence: {reversedSentence}");
        }

        #endregion
    }
}