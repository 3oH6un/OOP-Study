namespace JiSup._11장.UsingGenericList;

public class MainApp
{
    public static void _Main(string[] args)
    {
        List<int> list = new List<int>();
        for (int i = 0; i < 5; i++)
        {
            list.Add(i);
        }

        foreach (int element in list)
        {
            Console.Write($"{element} ");
        }

        Console.WriteLine();

        list.RemoveAt(2);

        foreach (int element in list)
        {
            Console.Write($"{element} ");
        }

        Console.WriteLine();
        
        list.Insert(2, 2);

        foreach (int element in list)
        {
            Console.Write($"{element} ");
        }

        Console.WriteLine();
    }
}