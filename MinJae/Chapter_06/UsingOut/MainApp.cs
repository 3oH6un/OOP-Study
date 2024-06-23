namespace MinJae.Chapter_06.UsingOut;

public class MainApp
{
    static void _Main(string[] args)
    {
        int a = 20;
        int b = 3;

        Divide(a, b, out int c, out int d);

        Console.WriteLine($"a: {a}, b: {b}, a/b: {c}, a%b: {d}");
    }

    static void Divide(int a, int b, out int quotient, out int remainder)
    {
        quotient = a / b;
        remainder = a % b;
    }
}