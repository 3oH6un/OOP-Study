namespace MinJae.Practice.Ex_06;

public class MainApp
{
    static void Main(string[] args)
    {
        Console.WriteLine("수를 입력하세요.");
        string input = Console.ReadLine();
        double arg = Convert.ToDouble(input);

        Console.WriteLine("결과: {0}", Square(arg));
    }

    static double Square(double arg)
    {
        return arg * arg;
    }
}