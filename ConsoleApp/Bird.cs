namespace CJackson;

public abstract class Bird
{
    protected abstract string Name { get; }

    public void Fly()
    {
        Console.WriteLine($"The {Name} soars!");
    }

    public virtual void Tweet()
    {
        Console.WriteLine("Tweet!");
    }
}

public class Goose : IBird, IDisposable
{
    protected string Name { get => "Goose"; }

    public void Dispose()
    {
        Console.WriteLine($"Chuck it in the bin!");
    }

    public void Fly()
    {
        Console.WriteLine($"The {Name} soars!");
    }

    public void Tweet()
    {
        Console.WriteLine("Honk!");
    }
}

public interface IBird
{
    public void Fly();

    public void Tweet();
}