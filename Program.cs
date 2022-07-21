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

            if (int.TryParse(num1, out var num1int) == true && int.TryParse(num2, out var num2int) == true)
            {
                total = num1int + num2int;
                Console.WriteLine($"The sum of your numbers is {total}");
            }
            else
            {
                Console.WriteLine("You are an idiot, please try using numbers this time!");
            }
        }
    }
}
