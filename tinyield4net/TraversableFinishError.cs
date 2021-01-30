using System;

namespace com.tinyield
{
    public class TraversableFinishError : Exception
    {
        public static readonly TraversableFinishError finishTraversal = new TraversableFinishError();

        private TraversableFinishError() : base("Auxiliary exception finishes traversal!")
        {
        }
    }
}
