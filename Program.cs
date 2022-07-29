using CJackson.Extensions;
using CJackson.Shapes;
namespace CJackson;
public class Program
{
    public static void Main(string[] args)
    {
        var pingu = new int[] { 1, 2, 5, 4, 7, 3, 9, 6 };
        Console.WriteLine(Counter(pingu));
    }

    public static int Counter(int[] intArr)
    {
        int counter = 0;
        foreach (var item in intArr)
        {
            if (item % 2 == 0)
            {
                counter = counter + 1;
            }
        }
        return counter;
    }
}
