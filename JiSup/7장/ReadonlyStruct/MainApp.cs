namespace JiSup._7장.ReadonlyStruct;

readonly struct RGBColor //JAVA의 final처럼 readonly키워드는 생성자에서는 초기화 할 수 있다. 하지만 그이후는 불가능.
{
    public readonly byte R;
    public readonly byte G;
    public readonly byte B;

    public RGBColor(byte r, byte g, byte b)
    {
        R = r;
        G = g;
        B = b;
    }
    
}

public class MainApp
{
    public static void _Main(string[] args)
    {
        RGBColor Red = new RGBColor(255, 0, 0);
        //Red.G = 100; Read only 임으로 컴파일이 오류 뜬다. /
    }
}