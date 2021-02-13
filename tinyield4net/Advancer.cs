namespace com.tinyield
{
    public delegate bool Advancer<T>(Yield<T> yield);

    public delegate bool Advancer(Yield<object> yield);

}
