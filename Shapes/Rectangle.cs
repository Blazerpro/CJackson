namespace CJackson.Shapes;

public class Rectangle : IShape
{
    public double Perimeter => (2 * Height) + (2 * Width);
    public double Area => Height * Width;

    public double Height { get; private set; }
    public double Width { get; private set; }

    public Rectangle(double height, double width)
    {
        Height = height;
        Width = width;
    }
}