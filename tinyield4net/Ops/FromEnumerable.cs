using System.Collections.Generic;

namespace com.tinyield.Ops
{
    public class FromEnumerable<T> : IOp<T>
    {
        private readonly IEnumerator<T> source;

        public FromEnumerable(IEnumerable<T> source)
        {
            this.source = source.GetEnumerator();
        }

        public void Traverse(Yield<T> yld)
        {
            while (source.MoveNext())
            {
                yld(source.Current);
            }
        }

        public bool TryAdvance(Yield<T> yld)
        {
            if (source.MoveNext())
            {
                yld(source.Current);
                return true;
            }
            return false;
        }
    }
}
