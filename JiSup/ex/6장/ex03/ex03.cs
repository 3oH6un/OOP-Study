﻿namespace JiSup.ex._6장.ex03;

public class ex03
{
    public static void _Main(string[] args)
    {
        int a = 3;
        int b = 4;
        int resultA = 0;

        Plus(a, b, out resultA);

        Console.WriteLine("{0} + {1} = {2}",a,b,resultA);

        double x = 2.4;
        double y = 3.1;
        double resultB = 0;
        
        Plus(x, y, out resultB);
        Console.WriteLine("{0} + {1} = {2}",x,y,resultB);

    }

    public static void Plus(int a, int b, out int c)
    {
        c = a + b;
    }

    public static double Plus(double a, double b, out double c)
    {
        return c = a + b;
    }
}