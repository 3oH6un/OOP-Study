namespace YongBin.exam._6장.문제1번;

public class MainApp
{
    public static void Main_(string[] args)
    {
        double mean = 0;
        Mean(1, 2, 3, 4, 5, ref mean);
        Console.WriteLine("평균 : {0}", mean);
    }

    public static void Mean(double a, double b, double c, double d, double e, ref double mean)
    {
        mean = (a + b + c + d + e) / 5;
    }
}