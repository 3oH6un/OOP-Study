namespace MinJae.Chapter_05.Break;

public class MainApp
{
    static void _Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("계속할까요? (예/아니오)");
            string answer = Console.ReadLine();

            if (answer == "아니오")
                break;
        }
    }
}