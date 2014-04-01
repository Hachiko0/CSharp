using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ExtensionMethodsLambdaLINQ
{
    public static class ExtensionMethods
    {
        public static StringBuilder Substring(this StringBuilder sb, int index, int length)
        {
            if (index < 0 || index >= sb.Length || length > sb.Length - index)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }
            return new StringBuilder(sb.ToString().Substring(index, length));
        }

        public static StringBuilder Substring(this StringBuilder sb, int index)
        {
            if (index < 0 || index >= sb.Length)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }
            return new StringBuilder(sb.ToString().Substring(index));
        }
        public static decimal Average<T>(this IEnumerable<T> collection)
            where T : IComparable
        {
            dynamic result = 0;
            if (typeof(T) == typeof(int) || typeof(T) == typeof(byte) || typeof(T) == typeof(uint) ||
                typeof(T) == typeof(long) || typeof(T) == typeof(ulong)
                || typeof(T) == typeof(ulong) || typeof(T) == typeof(decimal))
            {
                foreach (var item in collection)
                {
                    result += item;
                }
            }
            else
            {
                throw new ArgumentException("Wrong argument");
            }
            return (decimal)result / (collection.Count());
        }

        public static T Product<T>(this IEnumerable<T> collection)
            where T : IComparable
        {
            dynamic result = 1;
            if (typeof(T) == typeof(int) || typeof(T) == typeof(byte) || typeof(T) == typeof(uint) ||
                typeof(T) == typeof(long) || typeof(T) == typeof(ulong)
                || typeof(T) == typeof(ulong) || typeof(T) == typeof(decimal))
            {
                foreach (var item in collection)
                {
                    result *= item;
                }
                return (T)result;
            }
            else
            {
                throw new ArgumentException("Wrong argument");
            }
        }

        public static T Min<T>(this IEnumerable<T> collection)
            where T : IComparable
        {
            dynamic min = long.MaxValue;
            if (typeof(T) == typeof(int) || typeof(T) == typeof(byte) || typeof(T) == typeof(uint) ||
                typeof(T) == typeof(long) || typeof(T) == typeof(ulong)
                || typeof(T) == typeof(ulong) || typeof(T) == typeof(decimal))
            {
                foreach (var item in collection)
                {
                    if (item.CompareTo(min) == -1)
                    {
                        min = item;
                    }
                }
                return min;
            }
            else
            {
                throw new ArgumentException("wrong argument");
            }
        }

        public static T Max<T>(this IEnumerable<T> collection) 
            where T: IComparable
        {
            dynamic max = long.MinValue;
            foreach (var item in collection)
            {
                if (item.CompareTo(max) == 1)
                {
                    max = item;
                }
            }
            return max;
        }

        public static T Sum<T>(this IEnumerable<T> collection)
            where T: IComparable
        {
            dynamic sum = 0;
            foreach (var item in collection)
            {
                sum += item;
            }
            return sum;
        }
    }
}
