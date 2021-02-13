namespace com.tinyield
{
    public delegate void Traverser<T>(Yield<T> yield);

    public delegate void Traverser(Yield<object> yield);
}
