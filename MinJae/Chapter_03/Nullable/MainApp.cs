namespace MinJae.Chapter_03.Nullable;

public class MainApp
{
    static void _Main(string[] args)
    {
        int? a = null;

        Console.WriteLine(a.HasValue);
        Console.WriteLine(a != null);

        a = 3;

        Console.WriteLine(a.HasValue);
        Console.WriteLine(a != null);
        Console.WriteLine(a.Value);
    }
}