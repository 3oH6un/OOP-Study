namespace JiSup.ex._6장.ex01;

public class ex01
{
    static double Square(double arg)
    {
        //메소드 구현
        return arg * arg;
    }

    public static void _Main(string[] args)
    {
        Console.WriteLine("수를 입력하세요. : ");
        string input = Console.ReadLine();
        double arg = Convert.ToDouble(input);

        Console.WriteLine("결과 : {0}",Square(arg));
    }
}