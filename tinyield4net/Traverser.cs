namespace com.tinyield
{
    public delegate void Traverse<T>(Yield<T> yield);

    public interface Traverser
    {
        /// <summary>
        /// Yields elements sequentially in the current thread,
        /// until all elements have been processed or an
        /// exception is thrown.
        /// </summary>
        void Traverse(Yield<object> yield);
        public static Traverser<R> Empty<R>() => new TraverserImpl<R>(yld => { });

        public static Traverser<R> From<R>(Traverse<R> traverse)
        {
            return new TraverserImpl<R>(traverse);
        }
    }
    public interface Traverser<T>
    {
        /// <summary>
        /// Yields elements sequentially in the current thread,
        /// until all elements have been processed or an
        /// exception is thrown.
        /// </summary>
        void Traverse(Yield<T> yield);
    }

    internal class TraverserImpl<R> : Traverser<R>
    {
        private readonly Traverse<R> traverse;

        public TraverserImpl(Traverse<R> traverse)
        {
            this.traverse = traverse;
        }
        public void Traverse(Yield<R> yield)
        {
            this.traverse(yield);
        }
    }

}
