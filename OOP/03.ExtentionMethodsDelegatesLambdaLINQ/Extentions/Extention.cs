using System;
using System.Collections.Generic;
using System.Text;

namespace Extentions
{
    static class Extention
    {
        public static StringBuilder Substring(this StringBuilder text, int index, int length)
        {
            StringBuilder result = new StringBuilder(length);
            for (int i = index; i < index + length; i++)
            {
                result.Append(text[i]);
            }
            return result;
        }

        public static T Sum<T>(this IEnumerable<T> collection) where T : IComparable
        {
            dynamic sum = 0;
            foreach (T item in collection)
            {
                sum += item;
            }
            return sum;
        }

        public static T Product<T>(this IEnumerable<T> collection) where T : IComparable
        {
            dynamic product = 1;
            foreach (T item in collection)
            {
                product *= item;
            }
            return product;
        }

        public static T Min<T>(this IEnumerable<T> collection) where T : IComparable
        {
            dynamic min = collection.GetFirst<T>();
            foreach (T item in collection)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            return min;
        }

        public static T Max<T>(this IEnumerable<T> collection) where T : IComparable
        {
            dynamic max = collection.GetFirst<T>();
            foreach (T item in collection)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;
        }

        public static T Count<T>(this IEnumerable<T> collection) where T : IComparable
        {
            dynamic count = 0;
            foreach (T item in collection)
            {
                count++;
            }
            return count;
        }

        public static T Average<T>(this IEnumerable<T> collection) where T : IComparable
        {
            dynamic sum = collection.Sum<T>();
            dynamic count = collection.Count<T>();
            return sum / count;
        }

        public static string ToString<T>(this IEnumerable<T> collection) where T : IComparable
        {
            StringBuilder text = new StringBuilder();
            foreach (T item in collection)
            {
                text.Append(item);
                text.Append(" ");
            }
            return text.ToString();
        }

        private static T GetFirst<T>(this IEnumerable<T> collection)
        {
            foreach (T item in collection)
            {
                return item;
            }
            dynamic first = 0;
            return first;
        }
    }
}
