namespace CJackson.Program;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("What is your name?");

        var name = Console.ReadLine();

        Console.WriteLine("What is your age?");

        var age = Console.ReadLine();

        var fullstring = $"My name is {name} and age is {age}.";

        Console.WriteLine(fullstring);
    }
}
