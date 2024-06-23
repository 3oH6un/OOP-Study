namespace YongBin.exam._5장.Star3;

public class MainApp
{
    public static void Main_(string[] args)
    {
        int i = 4;

        while (i >= 0)
        {
            int j = 0;

            while (j <= i)
            {
                Console.Write("*");
                j++;
            }
            Console.WriteLine();
            i--;
        }
    }
}