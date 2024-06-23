using System.Collections;

namespace MinJae.Chapter_04.NullConditionalOperator;

public class MainApp
{
    static void _Main(string[] args)
    {
        ArrayList a = null;
        a?.Add("축구");
        a?.Add("야구");
        Console.WriteLine($"Count : {a?.Count}");
        Console.WriteLine($"{a?[0]}");
        Console.WriteLine($"{a?[1]}");

        a = new ArrayList();
        a?.Add("축구");
        a?.Add("야구");
        Console.WriteLine($"Count : {a?.Count}");
        Console.WriteLine($"{a?[0]}");
        Console.WriteLine($"{a?[1]}");
    }
}