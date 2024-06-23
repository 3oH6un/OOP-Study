namespace YongBin.exam._5장.Star4;

public class MainApp
{
    public static void Main_(string[] args)
    {
        int i = 0;
        do
        {
            int j = 5;

            do
            {
                Console.Write("*");
                j--;
            } while (i < j);
            
            Console.WriteLine();
            
            i++;
        } while (i < 5); 
    }   
}