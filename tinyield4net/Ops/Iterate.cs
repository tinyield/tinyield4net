using System;

namespace com.tinyield.Ops
{
    public class Iterate<T> : IOp<T>
    {
        private T prev;
        private Func<T, T> function;

        public Iterate(T seed, Func<T, T> function)
        {
            this.prev = seed;
            this.function = function;
        }

        public void Traverse(Yield<T> yield)
        {
            for (T curr = prev; true; curr = function(curr))
            {
                yield(curr);
            }
        }

        public bool TryAdvance(Yield<T> yield)
        {
            T curr = prev;
            prev = function(prev);
            yield(curr);
            return true;
        }
    }
}
