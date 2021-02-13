using System;

namespace com.tinyield.Ops
{
    public class DropWhile<T>
    {
        private readonly Query<T> upstream;
        private readonly Predicate<T> predicate;
        private bool dropped;

        public DropWhile(Query<T> upstream, Predicate<T> predicate)
        {
            this.upstream = upstream;
            this.predicate = predicate;
            dropped = false;
        }

        public void Traverse(Yield<T> yield)
        {
            upstream.adv(item =>
            {
                if (!dropped && !predicate(item))
                {
                    dropped = true;
                }
                if (dropped)
                {
                    yield(item);
                }
            });
        }

        public bool TryAdvance(Yield<T> yield)
        {
            if (dropped)
            {
                return upstream.adv(yield);
            }
            else
            {
                while (!dropped && DropNext(yield))
                {
                    // Intentionally empty. Action specified on yield statement of tryAdvance().
                }
                return dropped;
            }
        }

        private bool DropNext(Yield<T> yield)
        {
            return upstream.adv(item =>
            {
                if (!predicate(item))
                {
                    dropped = true;
                    yield(item);
                }
            });
        }
    }
}