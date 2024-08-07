namespace MinJae.Chapter_11.TryCatch;

public class MainApp
{
    static void _Main(string[] args)
    {
        int[] arr = { 1, 2, 3 };

        try
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine($"예외가 발생했습니다 : {e.Message}");
        }

        Console.WriteLine("종료");
    }
}