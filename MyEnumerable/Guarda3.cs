using System.Collections;

namespace MyEnumerable;

public class Guarda3<T> : IEnumerable<T>
{
    private T T0, T1, T2;
    
    public Guarda3()
    {
        T0 = default;
        T1 = default;
        T2 = default;
    }

    public T GetItem(int num)
    {
        if (num is < 0 or > 2)
        {
           throw new IndexOutOfRangeException();
        }

        if (num == 0) return T0;
        return num == 1 ? T1 : T2;
    }

    public void SetItem(int num, T item)
    {
        if (num is < 0 or > 2)
        {
            throw new IndexOutOfRangeException();
        }

        if (num == 0) T0 = item;
        else if (num == 1) T1 = item;
        else T2 = item;

    }
    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < 3; i++)
            yield return this.GetItem(i);

    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}