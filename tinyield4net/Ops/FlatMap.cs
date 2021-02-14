using System;

namespace com.tinyield.Ops
{
    public class FlatMap<T, R>
    {
        private readonly Query<T> upstream;
        private readonly Func<T, Query<R>> mapper;
        private Query<R> src;

        public FlatMap(Query<T> upstream, Func<T, Query<R>> mapper)
        {
            this.upstream = upstream;
            this.mapper = mapper;
            src = new Query<R>(yield => false, yield => { });
        }

        public void Traverse(Yield<R> yield)
        {
            upstream.Traverse(elem =>
                mapper(elem).Traverse(yield));
        }

        public bool TryAdvance(Yield<R> yield)
        {
            while (!src.TryAdvance(yield))
            {
                if (!upstream.TryAdvance(t => src = mapper(t)))
                    return false;
            }
            return true;
        }
    }
}