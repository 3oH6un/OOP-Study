
namespace YongBin.exam._3장.문제1번;

public class MainApp
{
    public static void Main_(string[] args)
    {
        Console.WriteLine("사각형의 너비를 입력하세요.");
        string width = Console.ReadLine();

        Console.WriteLine("사각형의 높이를 입력하세요.");
        string height = Console.ReadLine();

        int area = int.Parse(width) * int.Parse(height);

        Console.WriteLine("사각형의 넓이는 : {0}", area);

        float a = 7.3f;
        float b = 3.14f;
        double c = a * b;
        char d = "abc"[0];
        string e = new string(['한', '글']);

        Console.WriteLine(d);
        Console.WriteLine(e);
    }   
}