/// SPEC
/// Create a class called "Circle" with Methods "Perimeter" and "Area"
/// In the constructor, you should provide any dimensions needed to calculate these.
/// These dimensions should be stored in "properties", and should not be set-able from the outside.
/// They should, however, be get-able from the outside.

namespace CJackson.Shapes;

public class Circle
{
    public double Radius { get; private set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double Perimeter()
    {
        return Radius * 2 * Math.PI;
    }

    public double Area()
    {
        return Math.PI * Radius * Radius;
    }

}