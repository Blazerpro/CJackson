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
        var answer = 1;
        for (int i = 0; i < exponent; i++)
        {
            //              logical expression ? value if true : value if false
            answer = answer * ((exponent < 0) ? (1 / initial) : (initial));
        }
        return answer;
    }
}
