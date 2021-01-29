using System;
using System.Collections.Generic;
using System.Text;

namespace com.tinyield
{
    public interface Advancer<T>
    {
        /// <summary>
        /// If a remaining element exists, yields that element through
        /// the given action.
        /// </summary>
        bool TryAdvance(Yield<T> yield);
    }
}
