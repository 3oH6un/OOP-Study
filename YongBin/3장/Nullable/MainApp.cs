namespace YongBin._3장.Nullable;

public class MainApp
{
    static void Main_(string[] args)
    {
        int? a = null;

        Console.WriteLine(a.HasValue);          // 값이 없으면 false
        Console.WriteLine(a != null);

        a = 3;

        Console.WriteLine(a.HasValue);          // 값이 있으면 true
        Console.WriteLine(a != null);
        Console.WriteLine(a.Value);             // Nullable일 경우에는 value로 값을 가져와야 함
    }   
}