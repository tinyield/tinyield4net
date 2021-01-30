using System;
using System.Collections.Generic;
using System.Text;

namespace com.tinyield
{
    public interface Advancer
    {
        /// <summary>
        /// If a remaining element exists, yields that element through
        /// the given action.
        /// </summary>
        bool TryAdvance(Yield<object> yield);
        static Advancer<R> Empty<R>() => new EmptyAdvancer<R>();
    }
    public interface Advancer<T>
    {
        /// <summary>
        /// If a remaining element exists, yields that element through
        /// the given action.
        /// </summary>
        bool TryAdvance(Yield<T> yield);
    }

    internal class EmptyAdvancer<R> : Advancer<R>
    {
        public bool TryAdvance(Yield<R> yield)
        {
            return false;
        }
    }
}
