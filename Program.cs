using CJackson.Extensions;

namespace CJackson;
public class Program
{
    public static void Main(string[] args)
    {
        object[] objects = { new Product("iTunes", 1), 1, "Hi" };

        var iTunes = new Product("iTunes", 1);

        Console.WriteLine(iTunes.Version);
    }
}
