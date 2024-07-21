using System.Collections;

namespace MinJae.Chapter_10.InitializingCollections;

public class MainApp
{
    static void _Main(string[] args)
    {
        int[] arr = { 123, 456, 789 };

        ArrayList list = new ArrayList(arr);
        foreach (object item in list)
        {
            Console.WriteLine($"ArrayList : {item}");
        }
        Console.WriteLine();

        Stack stack = new Stack(arr);
        foreach (object item in stack)
        {
            Console.WriteLine($"Stack : {item}");
        }
        Console.WriteLine();

        Queue queue = new Queue(arr);
        foreach (object item in queue)
        {
            Console.WriteLine($"Queue : {item}");
        }
        Console.WriteLine();

        ArrayList arrayList2 = new ArrayList() {11, 22, 33};
        foreach (object item in arrayList2)
        {
            Console.WriteLine($"ArrayList2 : {item}");
        }
        Console.WriteLine();

        Hashtable ht = new Hashtable()
        {
            ["하나"] = 1,
            ["둘"] = 2,
            ["셋"] = 3
        };
        foreach (DictionaryEntry i in ht)
        {
            Console.WriteLine($"{i.Key} : {i.Value}");
        }
    }
}