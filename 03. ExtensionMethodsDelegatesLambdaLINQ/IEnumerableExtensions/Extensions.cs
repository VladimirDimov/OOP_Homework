
namespace IEnumerableExtensions
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public static class Extensions
    {
        public static T Sum<T>(this IEnumerable<T> collection)
        {
            T sum = default(T);
            foreach (var item in collection)
            {
                sum += (dynamic)item;
            }
            return sum;
        }

        public static T Product<T>(this IEnumerable<T> collection)
            where T : struct , IFormattable
        {
            T product = (dynamic)1;
            foreach (var item in collection)
            {
                product *= (dynamic)item;
            }
            return product;
        }

        public static T Min<T>(this IEnumerable<T> collection)
            where T : struct, IComparable
        {
            T[] temp = (dynamic)collection;
            T min = temp[0];
            foreach (var item in collection)
            {
                if (min.CompareTo(item) > 0)
                {
                    min = item;
                }
            }
            return min;
        }

        public static T Max<T>(this IEnumerable<T> collection)
            where T : struct, IComparable
        {
            T[] temp = (dynamic)collection;
            T min = temp[0];
            foreach (var item in collection)
            {
                if (min.CompareTo(item) < 0)
                {
                    min = item;
                }
            }
            return min;
        }

        public static T Average<T>(this IEnumerable<T> collection)
            where T : struct
        {
            T length = default(T);
            T sum = default(T);
            foreach (var item in collection)
            {
                length += (dynamic)1;
                sum += (dynamic)item;
            }
            return (T)((dynamic)sum / length);
        }

    }
}
