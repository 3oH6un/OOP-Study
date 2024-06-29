namespace JiSup._3장.StringNumberConverion;

public class MainApp
{
    public static void Main_(string[] args)
    {
        int a = 123;
        string b = a.ToString(); //a의 값을 문자열로 변환해서 String자료형의 b변수에 저장
        Console.WriteLine(b);

        float c = 3.14f;
        string d = c.ToString();
        Console.WriteLine(d);

        string e = "123456";
        int f = Convert.ToInt32(e);
        Console.WriteLine(f);

        string g = "1.2345";
        float h = float.Parse(g);
        Console.WriteLine(h);

    }
}