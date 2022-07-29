namespace CJackson;
public class Program
{
    public static void Main(string[] args)
    {
        var myIntArray = new int[] { 1, 2, 5, 4, 7, 3, 9, 6 };
        Console.WriteLine(Counter(myIntArray));
        Console.WriteLine(LINQCounter(myIntArray));
    }

    public static int Counter(IEnumerable<int> intCollection)
    {
        int counter = 0;
        foreach (var item in intCollection)
        {
            if (item % 2 == 0)
            {
                counter++;
            }
        }
        return counter;
    }

    public static int LINQCounter(IEnumerable<int> intCollection)
    {
        return intCollection.Count(i => i % 2 == 0);
    }
}
