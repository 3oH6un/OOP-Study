using System.Collections;

namespace JiSup._10장.InitializingCollections;

public class MainApp
{
    public static void _Main(string[] args)
    {
        int[] arr = { 123, 456, 789 };
        
        //배열을 이용한 자료구조 초기화 방법
        
        // list
        ArrayList list = new ArrayList(arr);
        foreach (object obj in list)
        {
            Console.WriteLine($"Arraylist : {obj}");
        }

        Console.WriteLine();
        //-------------------------------------------------
        
        //Stack
        Stack stack = new Stack(arr);
        foreach (object obj in stack)
        {
            Console.WriteLine($"Stack : {obj}");
        }

        Console.WriteLine();
        //-------------------------------------------------
        
        //Queue
        Queue queue = new Queue(arr);
        foreach (object obj in queue)
        {
            Console.WriteLine($"Queue : {obj}");
        }

        Console.WriteLine();
        //-------------------------------------------------
        
        //list2번째 방법
        ArrayList list2 = new ArrayList() { 11, 22, 33 };
        foreach (object obj in list2)
        {
            Console.WriteLine($"Arraylist2 : {obj}");
        }

        Console.WriteLine();
        //-------------------------------------------------
        
        //Hashtable
        Hashtable ht = new Hashtable()
        {
            ["하나"] = 1,
            ["둘"] = 2,
            ["셋"] = 3
        };
        
        foreach (object obj in ht.Values)
        {
            Console.WriteLine($"ht : {obj}");
        }
    }
}