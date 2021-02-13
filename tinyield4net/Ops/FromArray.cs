namespace com.tinyield.Ops
{
    public class FromArray<U>
    {
        private readonly U[] data;
        private int current;

        public FromArray(params U[] data)
        {
            this.data = data;
            this.current = 0;
        }

        public void Traverse(Yield<U> yield)
        {
            for (int i = current; i < data.Length; i++)
            {
                yield(data[i]);
            }
        }

        public bool TryAdvance(Yield<U> yield)
        {
            if (current >= data.Length) return false;
            yield(data[current++]);
            return true;
        }
    }
}
