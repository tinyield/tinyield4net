using System;

namespace com.tinyield.Ops
{
    public class Zip<T, U, R>
    {
        private readonly Query<T> upstream;
        private readonly Query<U> other;
        private readonly Func<T, U, R> zipper;

        public Zip(Query<T> query, Query<U> other, Func<T, U, R> zipper)
        {
            this.upstream = query;
            this.other = other;
            this.zipper = zipper;
        }

        public void Traverse(Yield<R> yield)
        {
            while (TryAdvance(yield)) { }
        }

        public bool TryAdvance(Yield<R> yield)
        {
            bool consumed = false;
            upstream.TryAdvance(e1 =>
            {
                other.TryAdvance(e2 =>
                {
                    yield(zipper(e1, e2));
                    consumed = true;
                });
            });
            return consumed;
        }
    }
}