namespace YongBin.exam._5장.Star2;

public class MainApp
{
    public static void Main_(string[] args)
    {
        int i = 0;
        
        do
        {
            int j = 0;
            do
            {
                Console.Write("*");
                j++;
            } while (j <= i);
            Console.WriteLine();
            i++;
        } while (i < 5);
    }
}