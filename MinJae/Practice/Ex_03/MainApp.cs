namespace MinJae.Practice.Ex_03;

public class MainApp
{
    static void _Main(string[] args)
    {
        Console.WriteLine("사각형의 너비를 입력하세요.");
        string width = Console.ReadLine();

        Console.WriteLine("사각형의 높이를 입력하세요.");
        string height = Console.ReadLine();

        int area = int.Parse(width) * int.Parse(height);
        Console.WriteLine($"사각형의 넓이는 : {area}");
    }
}