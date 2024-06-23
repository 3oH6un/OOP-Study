namespace JiSup.ex._5장.ex01;

public class Star
{
    public static void Main__(string[] args)
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < i+1; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        Console.WriteLine("=============================");
        
        int k = 0;
        
        while (k<5)
        {
            int l = 0;
            while (l<=k)
            {
                    Console.Write("*");
                    l++;
                    
            }

            
            k++;
            Console.WriteLine();
        }
        
        Console.WriteLine("=============================");

        k = 0;
        do
        {
            int l = 0;
            do
            {
                Console.Write("*");
                l++;
            } while (l<k+1);
            
            k++;
            Console.WriteLine();
        } while (k<5);
        
    }
}