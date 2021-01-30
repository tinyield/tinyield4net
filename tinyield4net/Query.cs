using com.tinyield.Ops;
using System;
using System.Collections.Generic;
using System.Linq;

namespace com.tinyield
{
    public class Query
    {
        public static Query<U> Of<U>(params U[] data)
        {
            FromArray<U> op = new FromArray<U>(data);
            return new Query<U>(op, op);
        }

        public static Query<U> Of<U>(IEnumerable<U> data)
        {
            FromEnumerable<U> op = new FromEnumerable<U>(data);
            return new Query<U>(op, op);
        }

        public static Query<U> Iterate<U>(U seed, Func<U, U> function)
        {
            Iterate<U> op = new Iterate<U>(seed, function);
            return new Query<U>(op, op);
        }

        public static Query<U> Generate<U>(Func<U> supplier)
        {
            Generate<U> op = new Generate<U>(supplier);
            return new Query<U>(op, op);
        }
    }

    public class Query<T>
    {
        private readonly Advancer<T> adv;
        private readonly Traverser<T> trav;

        public Query(Advancer<T> adv, Traverser<T> trav)
        {
            this.adv = adv;
            this.trav = trav;
        }

        public void Traverse(Yield<T> yield)
        {
            this.trav.Traverse(yield);
        }

        public void ForEach(Yield<T> yield)
        {
            Traverse(yield);
        }

        public bool TryAdvance(Yield<T> action)
        {
            return this.adv.TryAdvance(action);
        }

        public void ShortCircuit(Yield<T> yield)
        {
            try
            {
                this.trav.Traverse(yield);
            }
            catch (TraversableFinishError)
            {
                /* Proceed */
            }
        }

        public T FindFirst()
        {
            T result = default;
            if (!TryAdvance(elem => result = elem))
            {
                throw new InvalidOperationException("The source sequence is empty");
            }
            return result;
        }

        public T FindAny()
        {
            return FindFirst();
        }

        public bool AnyMatch(Predicate<T> predicate)
        {
            bool found = false;
            ShortCircuit(elem =>
            {
                if (predicate(elem))
                {
                    found = true;
                    YieldExt.Bye();
                }
            });
            return found;
        }

        public bool NoneMatch(Predicate<T> predicate)
        {
            return !AnyMatch(predicate);
        }

        public bool AllMatch(Predicate<T> predicate)
        {
            bool succeed = true;
            ShortCircuit(elem =>
            {
                if (!predicate(elem))
                {
                    succeed = false;
                    YieldExt.Bye();
                }
            });
            return succeed;
        }

        public T Max(Comparison<T> compare)
        {
            T max = default;
            bool found = false;
            Traverse(elem =>
            {
                if (!found)
                {
                    max = elem;
                    found = true;
                }
                else if (compare(max, elem) > 0)
                {
                    max = elem;
                }
            });
            if (!found)
            {
                throw new InvalidOperationException("The source sequence is empty");
            }
            return max;
        }

        public T Min(Comparison<T> compare)
        {
            return Max((one, another) => compare(one, another) * -1);
        }

        public Query<T> Sorted(Comparison<T> compare)
        {
            T[] src = ToArray();
            Array.Sort(src, compare);
            FromArray<T> sorted = new FromArray<T>(src);
            return new Query<T>(sorted, sorted);
        }


        public Query<R> Map<R>(Func<T, R> mapper)
        {
            Mapping<T, R> map = new Mapping<T, R>(this, mapper);
            return new Query<R>(map, map);
        }

        public IList<T> ToList()
        {
            IList<T> data = new List<T>();
            Traverse(data.Add);
            return data;
        }

        public ISet<T> ToSet()
        {
            ISet<T> data = new HashSet<T>();
            Traverse(i => { data.Add(i); });
            return data;
        }

        public T[] ToArray()
        {
            return ToList().ToArray();
        }

        public long Count()
        {
            int c = 0;
            Traverse(i => c++);
            return c;
        }

        public Query<T> Filter(Predicate<T> predicate)
        {
            Filter<T> filter = new Filter<T>(this, predicate);
            return new Query<T>(filter, filter);
        }

        public Query<T> Skip(int n)
        {
            Skip<T> skip = new Skip<T>(this, n);
            return new Query<T>(skip, skip);
        }

        public Query<T> DropWhile(Predicate<T> predicate)
        {
            DropWhile<T> dropWhile = new DropWhile<T>(this, predicate);
            return new Query<T>(dropWhile, dropWhile);
        }

        public Query<T> Limit(int n)
        {
            Limit<T> limit = new Limit<T>(this, n);
            return new Query<T>(limit, limit);
        }

        public Query<T> TakeWhile(Predicate<T> predicate)
        {
            TakeWhile<T> takeWhile = new TakeWhile<T>(this, predicate);
            return new Query<T>(takeWhile, takeWhile);
        }

        public Query<T> Concat(Query<T> other)
        {
            Concat<T> contact = new Concat<T>(this, other);
            return new Query<T>(contact, contact);
        }

        public Query<T> Peek(Action<T> action)
        {
            Peek<T> peek = new Peek<T>(this, action);
            return new Query<T>(peek, peek);
        }

        public Query<R> FlatMap<R>(Func<T, Query<R>> mapper)
        {
            FlatMap<T, R> flatMap = new FlatMap<T, R>(this, mapper);
            return new Query<R>(flatMap, flatMap);
        }

        public Query<T> Distinct()
        {
            Distinct<T> distinct = new Distinct<T>(this);
            return new Query<T>(distinct, distinct);
        }

        public Query<R> Zip<U, R>(Query<U> other, Func<T, U, R> zipper)
        {
            Zip<T, U, R> zip = new Zip<T, U, R>(this, other, zipper);
            return new Query<R>(zip, zip);
        }
    }
}
