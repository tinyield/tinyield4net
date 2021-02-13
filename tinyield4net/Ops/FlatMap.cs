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
            upstream.trav(elem =>
                mapper(elem).trav(yield));
        }

        public bool TryAdvance(Yield<R> yield)
        {
            while (!src.adv(yield))
            {
                if (!upstream.adv(t => src = mapper(t)))
                    return false;
            }
            return true;
        }
    }
}