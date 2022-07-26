using CJackson.Extensions;
using CJackson.Shapes;
namespace CJackson;
public class Program
{
    public static void Main(string[] args)
    {
        var shapeArray = new IShape[] { new Circle(5), new Rectangle(4, 3) };
        double total = 0;

        foreach (var item in shapeArray)
        {
            total = total + item.Area;
        }

        shapeArray.ForEach(shape => Console.WriteLine(shape.Area));

        var intArr = new List<int> { 1, 2, 5 };

        var newArr = intArr
            .Where(item => item > 1)
            .Select(item => item + 1.0)
            .ToArray();

        Console.WriteLine(string.Join(", ", newArr));
    }
}
