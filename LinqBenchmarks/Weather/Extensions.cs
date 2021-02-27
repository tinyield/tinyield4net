using com.tinyield;
using System.Collections.Generic;

namespace LinqBenchmarks.Weather
{
    public static class Extensions
    {
        public static IEnumerable<T> OddLines<T>(this IEnumerable<T> src)
        {
            var isOdd = false;
            foreach (var item in src)
            {
                if (isOdd) yield return item;
                isOdd = !isOdd;
            }
        }

        public static IEnumerable<T> Collapse<T>(this IEnumerable<T> src)
        {
            object prev = null;
            foreach (var item in src)
            {
                if (prev == null || !prev.Equals(item))
                {
                    prev = item;
                    yield return item;
                }
            }
        }

        public static Traverser<T> OddLines<T>(Query<T> src)
        {
            return yld =>
            {
                bool isOdd = false;
                src.Traverse(item =>
                {
                    if (isOdd) yld(item);
                    isOdd = !isOdd;
                });
            };
        }

        public static Traverser<T> Collapse<T>(Query<T> src)
        {
            return yld =>
            {
                object prev = null;
                src.Traverse(item =>
                {
                    if (prev == null || !prev.Equals(item))
                    {
                        prev = item;
                        yld(item);
                    }
                });
            };
        }
    }
}
