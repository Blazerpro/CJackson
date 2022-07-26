/// SPEC
/// Create a class called "Circle" with Methods "Perimeter" and "Area"
/// In the constructor, you should provide any dimensions needed to calculate these.
/// These dimensions should be stored in "properties", and should not be set-able from the outside.
/// They should, however, be get-able from the outside.

namespace CJackson.Shapes;

public class Circle : IShape
{
    public double Radius { get; private set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double Perimeter { get => Math.PI * 2 * Radius; }

    public double Area { get => Math.PI * Radius * Radius; }
}