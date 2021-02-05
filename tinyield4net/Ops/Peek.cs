using System;

namespace com.tinyield.Ops
{
    public class Peek<T> : IOp<T>
    {
        private Query<T> upstream;
        private Action<T> action;

        public Peek(Query<T> upstream, Action<T> action)
        {
            this.upstream = upstream;
            this.action = action;
        }

        public void Traverse(Yield<T> yield)
        {
            upstream.Traverse(item =>
            {
                action(item);
                yield(item);
            });
        }

        public bool TryAdvance(Yield<T> yield)
        {
            return upstream.TryAdvance(item =>
            {
                action(item);
                yield(item);
            });
        }
    }
}