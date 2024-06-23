namespace MinJae.Chapter_05.Continue;

public class MainApp
{
    static void _Main(string[] args)
    {
        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
                continue;

            Console.WriteLine($"{i} : 홀수");
        }
    }
}