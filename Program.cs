using CJackson.Extensions;

namespace CJackson;
public class Program
{
    public static void Main(string[] args)
    {
        object[] objects = { new Product("iTunes"), 1, "Hi" };

        var iTunes = new Product("iTunes");
        var chrome = new Product("iChrome");

        iTunes.ProductNameAppenderExtension();

        Console.WriteLine(iTunes.ProductNameAppender());
        Console.WriteLine(Product.ProductNameAppender(iTunes));
        Console.WriteLine(chrome.ProductNameAppender());

        objects.PrintAll();
    }
}
