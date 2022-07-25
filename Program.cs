using CJackson.Shapes;
namespace CJackson;
public class Program
{
    public static void Main(string[] args)
    {
        var leCircle = new Circle(4);

        Console.WriteLine(leCircle.Radius);
        Console.WriteLine(leCircle.Area());
        Console.WriteLine(leCircle.Perimeter());
    }
}
