using System;

namespace LinqBenchmarks.Every
{
    public class Value : IComparable<Value>
    {
        public readonly int source;
        public readonly String text;

        public Value(int value)
        {
            this.source = value;
            char[] charArray = value.ToString().ToCharArray();
            System.Array.Reverse(charArray);
            this.text = new string(charArray);
        }

        public int CompareTo(Value other)
        {
            return source.CompareTo(other.source);
        }

        public override bool Equals(Object o)
        {
            if (this == o)
            {
                return true;
            }
            if (o == null || GetType() != o.GetType())
            {
                return false;
            }
            Value value1 = (Value)o;
            return source == value1.source && text.Equals(value1.text);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(source, text);
        }
    }
}
