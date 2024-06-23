namespace MinJae.Chapter_06.Overloading;

public class MainApp
{
    static void _Main(string[] args)
    {
        Console.WriteLine(Plus(1, 2));
        Console.WriteLine(Plus(1, 2, 3));
        Console.WriteLine(Plus(1.0, 2.4));
        Console.WriteLine(Plus(1, 2.4));
    }

    static int Plus(int a, int b)
    {
        Console.WriteLine("Calling int Plus(int, int)...");
        return a + b;
    }

    static int Plus(int a, int b, int c)
    {
        Console.WriteLine("Calling int Plus(int, int, int)...");
        return a + b + c;
    }

    static double Plus(double a, double b)
    {
        Console.WriteLine("Calling int Plus(double, double)...");
        return a + b;
    }

    static double Plus(double a, double b, double c)
    {
        Console.WriteLine("Calling int Plus(double, double, double)...");
        return a + b + c;
    }
}