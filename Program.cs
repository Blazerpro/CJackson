namespace CJackson.Program;
public class Program
{
    public static void Main(string[] args)
    {
        var firstnum = 4;
        var exponent = -2;

        var answer = ExponentFunc(firstnum, exponent);
        Console.WriteLine(answer);
    }

    private static double ExponentFunc(int initial, int exponent)
    {
        var answer = 1.0;
        var counter = Math.Abs(exponent);
        for (int i = 0; i < counter; i++)
        {
            //              logical expression ? value if true : value if false
            answer = answer * ((exponent < 0) ? (1.0 / initial) : (initial));
        }
        return answer;
    }
}
