using System;

namespace com.tinyield.Ops
{
    public class TakeWhile<T>
    {
        private readonly Query<T> upstream;
        private readonly Predicate<T> predicate;
        private bool hasNext;

        public TakeWhile(Query<T> upstream, Predicate<T> predicate)
        {
            this.upstream = upstream;
            this.predicate = predicate;
            this.hasNext = true;
        }

        public void Traverse(Yield<T> yield)
        {
            while (TryAdvance(yield)) { }
        }

        public bool TryAdvance(Yield<T> yield)
        {
            if (!hasNext) return false; // Once predicate is false it finishes the iteration
            Yield<T> takeWhile = item =>
            {
                if (predicate(item))
                {
                    yield(item);
                }
                else
                {
                    hasNext = false;
                }
            };
            return upstream.adv(takeWhile) && hasNext;
        }
    }
}