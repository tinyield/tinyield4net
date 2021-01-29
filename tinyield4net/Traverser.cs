using System;
using System.Collections.Generic;
using System.Text;

namespace com.tinyield
{
    public interface Traverser<T>
    {
        /// <summary>
        /// Yields elements sequentially in the current thread,
        /// until all elements have been processed or an
        /// exception is thrown.
        /// </summary>
        void Traverse(Yield<T> yield);
    }

}
