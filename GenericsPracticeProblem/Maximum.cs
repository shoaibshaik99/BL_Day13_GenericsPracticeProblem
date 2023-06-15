internal class Maximum<T> where T : IComparable<T>
{
    private T[] values;

    public Maximum(params T[] values)
    {
        this.values = values;
    }

    public T TestMaximum()
    {
        return Maximum<T>.TestMaximum(values);
    }

    public static T TestMaximum(params T[] values)
    {
        if (values.Length == 0)
        {
            Console.WriteLine("No values provided");
            return default;
        }

        int n = values.Length;
        //bubble sort
        for (int i = 0; i < n - 1; i++)
        {
            bool swapped = false;
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (values[i].CompareTo(values[j]) > 0)
                {
                    T temp = values[i];
                    values[i] = values[j];
                    values[j] = temp;
                    swapped = true;
                }
            }
            if (swapped)
            {
                break;
            }
        }
        return values[n - 1];
    }
}