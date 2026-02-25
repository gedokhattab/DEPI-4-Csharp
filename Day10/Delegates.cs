using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    public class Delegates
    {

        public delegate string StringTransformer(string input);
        public delegate int IntOperation(int a, int b);
        public delegate R MapFunc<T, R>(T input);

        // specific to strings
        public static void StringOp(string[] items, StringTransformer transformer)
        {
            if (items == null) return;
            for (int i = 0; i < items.Length; i++)
                items[i] = transformer(items[i]);
        }
        // specific to ints
        public static void IntOp(int[] nums, IntOperation op)
        {
            if (nums == null) return;
            for (int i = 0; i < nums.Length; i++)
                nums[i] = op(nums[i], nums[i]);
        }
        // specific to int
        public static int IntOp(int num1, int num2, Func<int, int, int> op)
        {
            int result = op(num1, num2);
            return result;
        }
        // generic operations method
        public static void Operation<T>(List<T> items, Func<T, T> op)
        {
            if (items == null || op == null) return;
            for (int i = 0; i < items.Count; i++)
                items[i] = op(items[i]);
        }
        // generic map method
        public static List<R> Map<T, R>(List<T> items, MapFunc<T, R> map)
        {
            List<R> result = new List<R>();
            if (items == null) return result;
            foreach (T item in items)
                result.Add(map(item));
            return result;
        }

        // generic print method
        public static void Print<T>(List<T> items, Action<string> action)
        {
            if (items == null || action == null) return;
            foreach (var item in items)
                action(item.ToString());
        }

        // generic filter method
        public static List<T> Filter<T>(List<T> list, Predicate<T> predicate)
        {
            List<T> result = new List<T>();
            if (list == null || predicate == null) return result;

            foreach (T item in list)
                if (predicate(item))
                    result.Add(item);

            return result;
        }


        // specific to strings
        //public static List<string> FilterStrings(List<string> source, Predicate<string> predicate)
        //{
        //    List<string> result = new List<string>();
        //    if (source == null || predicate == null) return result;

        //    foreach (var item in source)
        //        if (predicate(item))
        //            result.Add(item);

        //    return result;
        //}

    }
}
