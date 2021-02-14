using System;

namespace com.tinyield.Ops
{
    public class Filter<T>
    {
        private readonly Query<T> upstream;
        private readonly Predicate<T> predicate;

        public Filter(Query<T> query, Predicate<T> predicate)
        {
            this.upstream = query;
            this.predicate = predicate;
        }

        public void Traverse(Yield<T> yield)
        {
            upstream.Traverse(e =>
            {
                if (predicate(e))
                {
                    yield(e);
                }
            });
        }

        public bool TryAdvance(Yield<T> yield)
        {
            bool found = false;
            bool hasNext = true;
            while (!found && hasNext)
            {
                hasNext = upstream.TryAdvance(e =>
                {
                    if (predicate(e))
                    {
                        yield(e);
                        found = true;
                    }
                });
            }
            return found;
        }
    }
}