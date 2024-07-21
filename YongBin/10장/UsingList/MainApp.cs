using System.Collections;

namespace YongBin._10장.UsingList;

public class MainApp
{
    static void Main_(string[] args)
    {
        ArrayList list = new ArrayList();

        for (int i = 0; i < 5; i++)
        {
            list.Add(i);
        }

        foreach (Object obj in list)
        {
            Console.Write($"{obj} ");
        }
        
        Console.WriteLine();
        
        list.RemoveAt(2);
        
        foreach (Object obj in list)
        {
            Console.Write($"{obj} ");
        }

        Console.WriteLine();
        
        list.Insert(2, 2);

        foreach (Object obj in list)
        {
            Console.Write($"{obj} ");
        }

        Console.WriteLine();

        list.Add("abc");
        list.Add("def");

        for (int i = 0; i < list.Count; i++)
        {
            Console.Write($"{list[i]} ");
        }

        Console.WriteLine();
        
    }
}