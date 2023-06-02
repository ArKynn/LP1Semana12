namespace TheyCameBefore;

public static class BeforeUtils
{
    public static IEnumerable<T> GetTheOnesBefore<T>(IEnumerable<T> enume, T num) where T : struct, IComparable
    {
        IEnumerable<T> finalEnum = Array.Empty<T>();

        foreach (T item in enume)
        {
            if (item.CompareTo(num) < 0)
            {
                yield return item;
            }
        }
    }
}