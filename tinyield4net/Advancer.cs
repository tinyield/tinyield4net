namespace com.tinyield
{
    public delegate bool TryAdvance<T>(Yield<T> yield);

    public interface Advancer
    {
        /// <summary>
        /// If a remaining element exists, yields that element through
        /// the given action.
        /// </summary>
        bool TryAdvance(Yield<object> yield);
        static Advancer<R> Empty<R>() => new AdvancerImpl<R>(yld => false);

        static Advancer<R> From<R>(TryAdvance<R> tryAdvance)
        {
            return new AdvancerImpl<R>(tryAdvance);
        }
    }
    public interface Advancer<T>
    {
        /// <summary>
        /// If a remaining element exists, yields that element through
        /// the given action.
        /// </summary>
        bool TryAdvance(Yield<T> yield);
    }

    internal class AdvancerImpl<R> : Advancer<R>
    {
        private readonly TryAdvance<R> tryAdvance;

        public AdvancerImpl(TryAdvance<R> tryAdvance)
        {
            this.tryAdvance = tryAdvance;
        }
        public bool TryAdvance(Yield<R> yield)
        {
            return this.tryAdvance(yield);
        }
    }
}
