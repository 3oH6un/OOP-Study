namespace JiSup.ex._5장.ex01;

public class StarReverse
{
    public static void Main__(string[] args)
    {
        for (int i = 5; i > 0; i--)
        {
            for (int j = 0; j<i ; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        Console.WriteLine("==========================================");

        int k = 5;
        while (k>0)
        {
            int j = 0;
            while (j<k)
            {
                Console.Write("*");
                j++;
            }
            Console.WriteLine();
            k--;
        }

        Console.WriteLine("==========================================");
        k = 5;
        do
        {
            int j = 0;
            do
            {
                Console.Write("*");
                j++;
            } while (j<k-1);
            
            Console.WriteLine();
            k--;
        } while (k>0);
    }
}