using System;

namespace Day04
{
    internal class Program
    {
        enum DayOfWeek { Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }



        static void Main(string[] args)
        {
            #region Problem 1
            int[] arr1 = new int[3];                 // new int[size]
            int[] arr2 = { 1, 2, 3 };                 // initializer list
            int[] arr3 = new int[] { 4, 5, 6 };       // array syntax sugar

            for (int i = 0; i < arr1.Length; i++)
                arr1[i] = i * 10;

            Console.WriteLine("arr1:");
            foreach (int x in arr1)
                Console.WriteLine(x);

            Console.WriteLine("arr2:");
            foreach (int x in arr2)
                Console.WriteLine(x);

            Console.WriteLine("arr3:");
            foreach (int x in arr3)
                Console.WriteLine(x);

            // IndexOutOfRangeException
            Console.WriteLine(arr1[5]);

            //Default value for int array elements is 0.

            #endregion

            #region Problem 2
            int[] arr = { 1, 2, 3 };
            int[] shallowCopy = arr1;
            shallowCopy[0] = 99;

            Console.WriteLine(arr1[0]); // affected

            int[] deepCopy = (int[])arr1.Clone();
            deepCopy[1] = 88;

            Console.WriteLine(arr1[1]); // not affected

            //Array.Clone() creates a new array(shallow copy of elements).
            //Array.Copy() copies elements into an existing array.

            #endregion

            #region Problem 3
            int[,] grades = new int[3, 3];

            for (int i = 0; i < grades.GetLength(0); i++)
                for (int j = 0; j < grades.GetLength(1); j++)
                {
                    Console.Write($"Student {i + 1}, Subject {j + 1}: ");
                    grades[i, j] = int.Parse(Console.ReadLine());
                }

            for (int i = 0; i < grades.GetLength(0); i++)
            {
                Console.Write($"Student {i + 1}: ");
                for (int j = 0; j < grades.GetLength(1); j++)
                    Console.Write(grades[i, j] + " ");
                Console.WriteLine();
            }

            //GetLength(dimension) -> size of a specific dimension
            //Length -> total number of elements

            #endregion

            #region Problem 4
            int[] arr4 = { 5, 1, 4, 2, 3 };

            Array.Sort(arr4); // sorted array : {1, 2, 3, 4, 5}
            foreach (int x in arr4)
                Console.Write(x + " ");
            Console.WriteLine();
            Array.Reverse(arr4); // reversed array : {5, 4, 3, 2, 1}
            foreach (int x in arr4)
                Console.Write(x + " ");
            Console.WriteLine();
            Console.WriteLine(Array.IndexOf(arr4, 3)); // output: 2

            int[] copy = new int[5];
            Array.Copy(arr4, copy, arr4.Length); // copy all elements

            Array.Clear(arr4, 0, 2); // arr4 : {0, 0, 3, 2, 1}
            foreach (int x in arr4)
                Console.Write(x + " ");
            Console.WriteLine();

            // Array.Copy() throws exception if copy fails
            // Array.ConstrainedCopy() guarantees rollback if failure happens

            #endregion

            #region Problem 5
            int[] arr5 = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < arr5.Length; i++)
                Console.WriteLine(arr5[i]);

            foreach (int x in arr5)
                Console.WriteLine(x);

            int index = arr5.Length - 1;
            while (index >= 0)
                Console.WriteLine(arr5[index--]);

            //foreach prevents modification -> safer for read-only access.

            #endregion

            #region Problem 6
            int num;

            do
            {
                Console.Write("Enter a positive odd number: ");
            } while (!int.TryParse(Console.ReadLine(), out num) || num <= 0 || num % 2 == 0);

            //Input validation prevents crashes and invalid program behavior.

            #endregion

            #region Problem 7
            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 } };

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write(matrix[i, j] + "\t");
                Console.WriteLine();
            }

            //Use tabs, spacing, or formatting (\t, alignment) for readability.

            #endregion

            #region Problem 8
            int month = int.Parse(Console.ReadLine());

            if (month == 1) Console.WriteLine("January");
            else if (month == 2) Console.WriteLine("February");
            else if (month == 3) Console.WriteLine("March");
            else if (month == 4) Console.WriteLine("April");
            else if (month == 5) Console.WriteLine("May");
            else if (month == 6) Console.WriteLine("June");
            else if (month == 7) Console.WriteLine("July");
            else if (month == 8) Console.WriteLine("August");
            else if (month == 9) Console.WriteLine("September");
            else if (month == 10) Console.WriteLine("October");
            else if (month == 11) Console.WriteLine("November");
            else if (month == 12) Console.WriteLine("December");
            else Console.WriteLine("Invalid");

            switch (month)
            {
                case 1: Console.WriteLine("January"); break;
                case 2: Console.WriteLine("February"); break;
                case 3: Console.WriteLine("March"); break;
                case 4: Console.WriteLine("April"); break;
                case 5: Console.WriteLine("May"); break;
                case 6: Console.WriteLine("June"); break;
                case 7: Console.WriteLine("July"); break;
                case 8: Console.WriteLine("August"); break;
                case 9: Console.WriteLine("September"); break;
                case 10: Console.WriteLine("October"); break;
                case 11: Console.WriteLine("November"); break;
                case 12: Console.WriteLine("December"); break;
                default: Console.WriteLine("Invalid"); break;
            }

            //Switch-case is cleaner and more efficient for multiple discrete values.

            #endregion

            #region Problem 9
            int[] arr6 = { 5, 2, 9, 2, 1 };

            Array.Sort(arr6);
            Console.WriteLine(Array.IndexOf(arr6, 2));
            Console.WriteLine(Array.LastIndexOf(arr6, 2));

            // Array.Sort() -> O(n log n)

            #endregion

            #region Problem 10
            int[] arr7 = { 1, 2, 3, 4 };
            int sum1 = 0, sum2 = 0;

            for (int i = 0; i < arr7.Length; i++)
                sum1 += arr7[i];

            foreach (int x in arr7)
                sum2 += x;

            Console.WriteLine(sum1);
            Console.WriteLine(sum2);

            // Both loops have O(n) time complexity.
            // foreach is more readable for simple iterations. abstract away the index management.
            // for loop offers more control (index management, skipping).

            #endregion

            #region Part 02

            int res;
            string answer;
            do
            {
                Console.Write("Enter a number between 1 and 7(Day of Week): ");
                answer= Console.ReadLine();
            }
            while (!int.TryParse(answer, out res) || res < 1 || res > 7);

            DayOfWeek day = (DayOfWeek)Enum.Parse(
               typeof(DayOfWeek),
               ((DayOfWeek)(res - 1)).ToString());

            Console.WriteLine("Day: " + day);

            // If the user enters a value outside 1 to 7, nothing breaks and nothing is printed until they fix it.
            // Otherwise: Enum.Parse will throw an exception if convert an out-of-range value.

            #endregion

        }
    }
}