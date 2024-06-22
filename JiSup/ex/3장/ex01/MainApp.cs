using System;
namespace JiSup.ex._3장.ex01;

public class MainApp
{
    public static void Main__(string[] args)
    {
        Console.WriteLine("사각형의 너비를 입력하세요.");
        string width = Console.ReadLine();
        
        Console.WriteLine("사각형의 높이를 입력하세요.");
        string height = Console.ReadLine();


        int area = int.Parse(width) * int.Parse(height);
        
        Console.WriteLine("사각형의 넓이 '{0}'",area);

        int a = 7;
        float b = 3.14f;
        double c = (double)a * b;
        char d = 'A';
        string e = "한"; //string 은 ""만 사용가능
        string f = new string(['한','글']);//문자배열을 string 객체로 만들어야함


    }
}