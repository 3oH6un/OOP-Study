namespace JiSup._3장.Nullable;

public class MainApp
{
    public static void Main__(string[] args)
    {
        int? a = null;
        
        Console.WriteLine(a.HasValue);
        Console.WriteLine(a != null);
        
        a = 3;
        
        Console.WriteLine(a.HasValue); //값을 접근 할때는 .value를 사용
        Console.WriteLine(a != null);   //Hasvalue는 값이 있는지 없는지 체크할때 사용
        Console.WriteLine(a.Value);
        
    }
}