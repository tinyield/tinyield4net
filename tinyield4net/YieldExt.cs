using System;
using System.Collections.Generic;
using System.Text;

namespace com.tinyield
{
    public static class YieldExt
    {
        static void Bye<T>(this Yield<T> cons)
        {
            throw TraversableFinishError.finishTraversal;
        }

    }
}
