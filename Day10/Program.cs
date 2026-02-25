using Day10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08
{
    internal class Program
    {


        static void Main(string[] args)
        {

            Console.Write("Enter your choice (1 - 6): ");
            string choice = Console.ReadLine();

            Action selectedProgram = choice switch
            {
                "1" => Program1,
                "2" => Program2,
                "3" => Program3,
                "4" => Program4,
                "5" => Program5,
                "6" => Program6,
                _ => () => Console.WriteLine("Invalid choice. Please select 1-6.")
            };

            selectedProgram();

        }

        #region Part01

        public static void Program1()
        {
            Employee[] employees =
            {
                new Employee { Name = "Alice", Salary = 50000 },
                new Employee { Name = "Bob", Salary = 60000 },
                new Employee { Name = "Charlie", Salary = 55000 }
            };
            Manager[] managers = {
                new Manager { Name = "David", Salary = 80000, Department = "HR" },
                new Manager { Name = "Eve", Salary = 75000 , Department = "IT"}
            };

            Employee[] employees1 = employees.Select(e => (Employee)e.Clone()).ToArray();
            // Cloning the employees into employees1

            SortingAlgorithm<Employee>.Sort(employees); // Sorting the original employees
            foreach (Employee employee in employees)
                Console.WriteLine(employee);

            SortingAlgorithm<Manager>.Sort(managers); // Sorting the managers
            foreach (Employee manager in managers)
                Console.WriteLine(manager);

            SortingAlgorithm<Employee>.Sort(employees1); // Sorting the cloned employees
            foreach (Employee employee in employees)
                Console.WriteLine(employee);

            Func<Employee, Employee, bool> SortDesc = (x, y) => (x?.Name?.Length ?? 0) < (y?.Name?.Length ?? 0);
            SortingAlgorithm<Employee>.Sort(employees, SortDesc);
            // Sorting the original employees in descending order by name length
            foreach (Employee employee in employees)
                Console.WriteLine(employee);
        }
        public static void Program2()
        {
            int[] numbers = { 5, 2, 9, 1, 5, 6 };
            SortingTwo<int>.Sort(numbers, (x, y) => x < y ? 1 : -1);
            foreach (int number in numbers)
                Console.WriteLine(number);

            string[] names = { "James", "Ali", "Mohamed", "Malek" };
            SortingTwo<string>.Sort(names, (x, y) => x.Length > y.Length ? 1 : -1);
            foreach (string name in names)
                Console.WriteLine(name);

            SortingTwo<int>.Sort(numbers, (x, y) => x > y ? 1 : -1);
            foreach (int number in numbers)
                Console.WriteLine(number);

        }
        public static void Program3()
        {
            Employee[] employees =
            {
                new Employee { Name = "Alice", Salary = 50000 },
                new Employee { Name = "Bob", Salary = 60000 },
                new Employee { Name = "Charlie", Salary = 55000 }
            };

            Func<Employee, Employee, bool> SortBySalaryThenName = (x, y) =>
            {
                if (x.Salary > y.Salary)
                    return true;
                else if (x.Salary < y.Salary)
                    return false;
                else
                {
                    Func<Employee, Employee, bool> SortByName = (a, b) =>
                                                   (a?.Name?.Length ?? 0) > (b?.Name?.Length ?? 0);
                    return SortByName(x, y);
                }
            };
            SortingAlgorithm<Employee>.Sort(employees, SortBySalaryThenName);
            foreach (Employee employee in employees)
                Console.WriteLine(employee);
        }

        public static void Program4()
        {
            // 1. Value Type (int)
            GetDefault(5); // Output: 0

            // 2. Value Type (bool)
            GetDefault(true);// Output: False

            // 3. Reference Type (string)
            GetDefault("String"); // Output: null

            // 4. Custom Reference Type (Employee)
            GetDefault(new Employee());// Output: null
        }

        public static void GetDefault<T>(T value)
        {
            T defaultValue = default(T);
            Console.WriteLine($"Default value of type {typeof(T)} is: {defaultValue}");
        }

        public static void Program5()
        {
            string[] names = { "James", "Ali", "Mohamed", "Malek" };

            Delegates.StringOp(names, (name) => name.ToUpper());
            Console.WriteLine("***********************************");
            Delegates.Print(names.ToList(), (name) => Console.WriteLine(name));


            Delegates.StringOp(names, (name) => char.ToUpper(name[0]) + name.Substring(1).ToLower());
            Console.WriteLine("***********************************");
            Delegates.Print(names.ToList(), (name) => Console.WriteLine(name));

            //--------------------------------------------------

            List<int> namesLength = Delegates.Map<string, int>(names.ToList(), (name) => name.Length);
            Console.WriteLine("***********************************");
            Delegates.Print(namesLength, (name) => Console.WriteLine(name));

            List<int> numbersList = new List<int> { 1, 2, 3, 4, 5 };
            List<string> stringRepresentation = Delegates.Map<int, string>(numbersList, (num) => $"Number: {num}");
            Console.WriteLine("***********************************");
            Delegates.Print(stringRepresentation, (name) => Console.WriteLine(name));

            //--------------------------------------------------

            Predicate<string> filterCondition = (string name) => name.Length > 3;
            List<string> FilteredName = Delegates.Filter(names.ToList(), filterCondition);
            Console.WriteLine("***********************************");
            Delegates.Print(FilteredName, (name) => Console.WriteLine(name));

            FilteredName = Delegates.Filter(names.ToList(), (name) => name.Contains("a"));
            Console.WriteLine("***********************************");
            Delegates.Print(FilteredName, (name) => Console.WriteLine(name));

        }

        public static void Program6()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            Delegates.IntOp(numbers, (num1, num2) => num1 * num2);
            Console.WriteLine("***********************************");
            Delegates.Print(numbers.ToList(), (number) => Console.WriteLine(number));

            Delegates.IntOp(numbers, (num1, num2) => num1 + num2);
            Console.WriteLine("***********************************");
            Delegates.Print(numbers.ToList(), (number) => Console.WriteLine(number));


            Delegates.IntOp(numbers, (num1, num2) => num1 / num2);
            Console.WriteLine("***********************************");
            Delegates.Print(numbers.ToList(), (number) => Console.WriteLine(number));


            Delegates.IntOp(numbers, (num1, num2) => num1 - num2);
            Console.WriteLine("***********************************");
            Delegates.Print(numbers.ToList(), (number) => Console.WriteLine(number));

            Delegates.Filter<int>(numbers.ToList(), (num1) => num1 % 2 == 0);
            Console.WriteLine("***********************************");
            Delegates.Print(numbers.ToList(), (number) => Console.WriteLine(number));

            //--------------------------------------------------

            var IntOperation = (int num1, int num2) => (int)Math.Pow(num1, num2);

            int res = Delegates.IntOp(5, 5, IntOperation);
            Console.WriteLine("***********************************");
            Console.WriteLine(res);

            res = Delegates.IntOp(5, 5, (num1, num2) => num1 + num2);
            Console.WriteLine("***********************************");
            Console.WriteLine(res);
        }
        public static void Program7()
        {
        }

        #endregion
    }
}
