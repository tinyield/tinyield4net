using System;

namespace com.tinyield.Ops
{
    public class Mapping<T, R>
    {
        private readonly Query<T> upstream;
        private readonly Func<T, R> mapper;

        public Mapping(Query<T> adv, Func<T, R> mapper)
        {
            this.upstream = adv;
            this.mapper = mapper;
        }

        public void Traverse(Yield<R> yield)
        {
            upstream.trav(e => yield(mapper(e)));
        }

        public bool TryAdvance(Yield<R> yield)
        {
            return upstream.adv(item => yield(mapper(item)));
        }
    }
}
