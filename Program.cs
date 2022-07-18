namespace CJackson.Program;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Give me a number:");

        var num1 = Console.ReadLine();

        Console.WriteLine("Give me a second number:");

        var num2 = Console.ReadLine();

        var total = int.Parse(num1) + int.Parse(num2);

        Console.WriteLine($"The sum of your numbers is {total}");
    }
}
