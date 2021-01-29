using System;
using System.Collections.Generic;
using System.Text;

namespace com.tinyield
{
    public class TraversableFinishError : Exception
    {
        public static readonly TraversableFinishError finishTraversal = new TraversableFinishError();

        private TraversableFinishError(): base("Auxiliary exception finishes traversal!")
        {
        }
    }
}
