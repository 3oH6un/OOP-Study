namespace JiSup._3장.IntegeralConversion;

public class MainApp
{
    public static void Main__(string[] args)
    {
        sbyte a = 127; //부호있는 정수 임으로 -128~127까지 
        Console.WriteLine(a);

        int b = (int)a; 
        
        Console.WriteLine(b);

        int x = 128;
        Console.WriteLine(x);

        sbyte y = (sbyte)x;
        Console.WriteLine(y);
        
    }
}