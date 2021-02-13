namespace com.tinyield.Ops
{
    public class Limit<T>
    {
        private readonly Query<T> upstream;
        private readonly int n;
        private int count;

        public Limit(Query<T> upstream, int n)
        {
            this.upstream = upstream;
            this.n = n;
            count = 0;
        }

        public void Traverse(Yield<T> yield)
        {
            if (count >= n)
                throw new System.InvalidOperationException("Traverser has already been operated on or closed!");
            while (TryAdvance(yield))
            {
                // Intentionally empty. Action specified on yield statement of tryAdvance().
            }
        }

        public bool TryAdvance(Yield<T> yield)
        {
            if (count >= n) return false;
            count++;
            return upstream.adv(yield);
        }
    }
}