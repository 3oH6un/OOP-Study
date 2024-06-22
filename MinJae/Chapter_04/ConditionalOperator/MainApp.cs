namespace MinJae.Chapter_04.ConditionalOperator;

public class MainApp
{
    static void _Main(string[] args)
    {
        string result = (10 % 2) == 0 ? "짝수" : "홀수";

        Console.WriteLine(result);
    }
}