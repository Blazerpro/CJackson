namespace CJackson.Extensions;

public static class ArrayExtensions
{
    public static void PrintAll(this object[] arr)
    {
        foreach (var item in arr)
        {
            Console.WriteLine(item.ToString());
        }
    }

    public static void ForEach<T>(this T[] arr, Action<T> action)
    {
        foreach (var item in arr)
        {
            action.Invoke(item);
        }
    }

    public static T2[] Transform<T1, T2>(this IList<T1> arr, Func<T1, T2> action)
    {
        T2[] newValues = new T2[arr.Count];

        for (int i = 0; i < arr.Count; i++)
        {
            newValues[i] = action(arr[i]);
        }

        return newValues;
    }
}