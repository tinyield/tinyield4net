using System.Collections.Generic;

namespace com.tinyield.Ops
{
    public class Distinct<T>
    {
        private readonly Query<T> upstream;
        private readonly HashSet<T> mem;

        public Distinct(Query<T> upstream)
        {
            this.upstream = upstream;
            mem = new HashSet<T>();
        }

        public void Traverse(Yield<T> yield)
        {
            upstream.trav(item =>
            {
                if (mem.Add(item)) yield(item);
            });
        }

        public bool TryAdvance(Yield<T> yield)
        {
            bool found = false;
            while (!found && upstream.adv(item =>
            {
                if (mem.Add(item))
                {
                    yield(item);
                    found = true;
                }
            })) ;
            return found;
        }
    }
}