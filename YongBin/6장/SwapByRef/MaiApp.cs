namespace YongBin._6장.SwapByRef;

public class MaiApp
{
    static void Swap(ref int a, ref int b)
    {
        int temp = b;
        b = a;
        a = temp;
    }

    static void Main_(string[] args)
    {
        int x = 3;
        int y = 4;
        
        Console.WriteLine($"x : {x}, y : {y}");
        
        Swap(ref x, ref y);
        
        Console.WriteLine($"x : {x}, y : {y}");
    }
}