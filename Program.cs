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
    }
}
