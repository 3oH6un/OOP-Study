using System.Collections;
using static System.Console;

namespace YongBin._10장.InitializingCollections;

public class MainApp
{
    static void Main_(string[] args)
    {
        int[] arr = { 123, 456, 789 };

        ArrayList list = new ArrayList(arr);

        foreach (Object item in list)
        {
            WriteLine($"ArrayList : {item}");
        }
        WriteLine();

        Stack stack = new Stack(arr);

        foreach (Object item in stack)
        {
            WriteLine($"Stack : {item}");
        }
        WriteLine();

        Queue queue = new Queue(arr);

        foreach (Object item in queue)
        {
            WriteLine($"Queue : {item}");
        }
        WriteLine();

        ArrayList list2 = new ArrayList() { 11, 22, 33 };

        foreach (Object item in list2)
        {
            WriteLine($"ArrayList2 : {item}");
        }
        WriteLine();

        Hashtable ht = new Hashtable()
        {
            ["하나"] = 1,     // ;가 아니라 ,를 이용하여 항목을 구분
            ["둘"] = 2,
            ["셋"] = 3
        };

        foreach (Object item in ht)
        {
            WriteLine($"Hashtable : {item}");
        }
    }
}