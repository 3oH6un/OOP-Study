namespace YongBin.exam._5장.Star;

public class MainApp
{
    public static void Main_(string[] args)
    {
        int i = 1;

        while (i <= 5)
        {
            int j = 0;
            while (true)
            {
                if (j < i)
                {
                    Console.Write("*");
                    j++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine();
            i++;
        }
    }
}