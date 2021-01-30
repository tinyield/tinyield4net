namespace com.tinyield
{
    public static class YieldExt
    {
        public static void Bye<T>(this Yield<T> cons)
        {
            throw TraversableFinishError.finishTraversal;
        }

        public static void Bye()
        {
            throw TraversableFinishError.finishTraversal;
        }

    }
}
