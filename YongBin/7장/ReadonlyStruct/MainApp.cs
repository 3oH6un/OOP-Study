namespace YongBin._7장.ReadonlyStruct;

readonly struct RGBColor
{
    public readonly byte R;
    public readonly byte G;
    public readonly byte B;

    public RGBColor(byte r, byte g, byte b)
    {
        R = r;
        G = r;
        B = b;
    }
}

public class MainApp
{
    static void Main_(string[] args)
    {
        RGBColor Red = new RGBColor(255, 0, 0);
        // Red.G = 100 // 컴파일 에러
    }
}