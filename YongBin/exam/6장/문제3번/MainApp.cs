using System.Numerics;

namespace YongBin.exam._6장.문제3번;

public class MainApp
{
    static int Plus(int a, int b)
    {
        return a + b;
    }

    static double Plus(double a, double b)
    {
        return a + b;
    }

    public static void Main_(string[] args)
    {
        Console.WriteLine("3 + 4 = {0}", Plus(3, 4));
        Console.WriteLine("2.4 + 3.1 = {0}", Plus(2.4, 3.1));
    }
}