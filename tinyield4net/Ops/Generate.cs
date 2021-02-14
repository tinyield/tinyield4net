using System;

namespace com.tinyield.Ops
{
    public class Generate<U>
    {
        private readonly Func<U> supplier;

        public Generate(Func<U> supplier)
        {
            this.supplier = supplier;
        }

        public void Traverse(Yield<U> yield)
        {
            while (true)
            {
                yield(supplier());
            }
        }

        public bool TryAdvance(Yield<U> yield)
        {
            yield(supplier());
            return true;
        }
    }
}