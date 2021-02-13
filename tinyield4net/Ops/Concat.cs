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
            upstream.trav(yield);
            other.trav(yield);
        }

        public bool TryAdvance(Yield<T> yield)
        {
            return upstream.adv(yield) || other.adv(yield);
        }
    }
}