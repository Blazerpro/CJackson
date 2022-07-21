namespace CJackson.Program;
public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Give me a number:");

            var num1 = Console.ReadLine();

            Console.WriteLine("Give me a second number:");

            var num2 = Console.ReadLine();

            int total = 1;

            try
            {
                total = int.Parse(num1) + int.Parse(num2);
            }
            catch
            {
                Console.WriteLine("You are an idiot, please try using numbers this time!");
                continue;
            }

            Console.WriteLine($"The sum of your numbers is {total}");
        }
    }
}
