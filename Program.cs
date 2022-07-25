namespace CJackson;
public class Program
{
    public static void Main(string[] args)
    {
        object[] objects = { new Product("iTunes"), 1, "Hi" };

        object product = new Product("iTunes");

        for (int i = 0; i < objects.Length; i++)
        {
            Console.WriteLine(objects[i].ToString());
        }
    }
}
