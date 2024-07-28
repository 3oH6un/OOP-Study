namespace YongBin._12장.TryCatch;

public class MainApp
{
    static void Main_(string[] args)
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
            throw;
        }

        Console.WriteLine("종료");
    }
}