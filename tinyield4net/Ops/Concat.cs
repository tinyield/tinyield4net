namespace com.tinyield.Ops
{
    public class Concat<T>
    {
        private readonly Query<T> upstream;
        private readonly Query<T> other;

        public Concat(Query<T> upstream, Query<T> other)
        {
            this.upstream = upstream;
            this.other = other;
        }

        public void Traverse(Yield<T> yield)
        {
            upstream.Traverse(yield);
            other.Traverse(yield);
        }

        public bool TryAdvance(Yield<T> yield)
        {
            return upstream.TryAdvance(yield) || other.TryAdvance(yield);
        }
    }
}