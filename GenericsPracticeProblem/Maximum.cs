internal class Maximum<T> where T : IComparable<T>
{
    private T a, b, c;

    public Maximum(T a, T b, T c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public T TestMaximum()
    {
        return Maximum<T>.TestMaximum(a, b, c);
    }

    public static T TestMaximum(T a, T b, T c)
    {
        T max = a;
        if (b.CompareTo(max) > 0)
        {
            max = b;
        }
        if (c.CompareTo(max) > 0)
        {
            max = c;
        }
        return max;
    }
}
