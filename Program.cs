namespace CJackson.Program;
public class Program
{
    public static void Main(string[] args)
    {
        var firstnum = 4;
        var exponent = 3;

        var answer = ExponentFunc(firstnum, exponent);
        Console.WriteLine(answer);
    }

    private static int ExponentFunc(int initial, int exponent)
    {
        var answer = initial;
        for (int i = 1; i < exponent; i++)
        {
            answer = answer * initial;
        }
        return answer;
    }
}
