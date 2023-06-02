namespace HowManyOfThisType;

public static class Checker
{
    public static int HowManyOfType<T>(IEnumerable<object> items)
    {
        int numOfItems = 0;
        foreach (var item in items)
        {
            if (item.GetType() == typeof(T)) numOfItems++;
        }

        return numOfItems;
    }
}