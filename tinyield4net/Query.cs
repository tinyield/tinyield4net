using com.tinyield.Ops;
using System;
using System.Collections.Generic;
using System.Text;

namespace com.tinyield
{
    public class Query {
        public static Query<U> of<U>(params U[] data)
        {
            FromArray<U> adv = new FromArray<U>(data);
            return new Query<U>(adv, adv);
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
        public bool TryAdvance(Yield<T> action)
        {
            return this.adv.TryAdvance(action);
        }


        public Query<R> Map<R>(Func<T, R> mapper) {
            Mapping<T, R> map = new Mapping<T,R>(this, mapper);
            return new Query<R>(map, map);
        }

        public IList<T> ToList() {
            IList<T> data = new List<T>();
            this.Traverse(data.Add);
            return data;
        }
    }
}
