namespace JiSup._3장.Nullable;

public class MainApp
{
    public static void Main__(string[] args)
    {
        int? a = null;

        Console.WriteLine(a.HasValue);
        Console.WriteLine(a != null);

        a = 3;

        Console.WriteLine(a.HasValue);
        Console.WriteLine(a != null);
        Console.WriteLine(a.Value);
        
    }
}