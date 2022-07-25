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
}