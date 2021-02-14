namespace com.tinyield.Ops
{
    public class Skip<T>
    {
        private readonly Query<T> upstream;
        private readonly int n;
        private int index;


        public Skip(Query<T> upstream, int n)
        {
            this.upstream = upstream;
            this.n = n;
        }

        public void Traverse(Yield<T> yield)
        {
            upstream.Traverse(e =>
            {
                if (index++ >= n)
                {
                    yield(e);
                }
            });
        }

        public bool TryAdvance(Yield<T> yield)
        {
            for (; index < n; index++)
                upstream.TryAdvance(item => { });
            return upstream.TryAdvance(yield);
        }
    }
}