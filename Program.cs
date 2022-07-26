using CJackson.Shapes;
namespace CJackson;
public class Program
{
    public static void Main(string[] args)
    {
        Goose bird = new Goose();

        IDisposable[] disposables = { bird };

        foreach (var item in disposables)
        {
            item.Dispose();
        }

        bird.Fly();

        var shapeArray = new IShape[] { new Circle(5), new Rectangle(4, 3) };
        double total = 0;

        foreach (var item in shapeArray)
        {
            total = total + item.Area;
        }

        Console.WriteLine($"The total area of the shapes is: {total}");
    }
}
