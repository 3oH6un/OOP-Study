namespace MinJae.Chapter_06.SwapByRef;

public class MainApp
{
    static void _Main(string[] args)
    {
        int x = 10;
        int y = 20;

        Console.WriteLine($"x: {x}, y: {y}");

        Swap(ref x, ref y);

        Console.WriteLine($"x : {x}, y : {y}");
    }

    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
}