namespace MinJae.Chapter_10.Indexer;

public class MainApp
{
    static void _Main(string[] args)
    {
        MyList list = new MyList();
        for (int i = 0; i < 5; i++)
        {
            list[i] = i;
        }

        for (int i = 0; i < list.Length; i++)
        {
            Console.WriteLine(list[i]);
        }
    }
}

class MyList
{
    private int[] array;

    public MyList()
    {
        array = new int[3];
    }

    public int this[int index]
    {
        get { return array[index]; }
        set
        {
            if (index >= array.Length)
            {
                Array.Resize<int>(ref array, index + 1);
                Console.WriteLine($"Array Resized : {array.Length}");
            }

            array[index] = value;
        }
    }

    public int Length
    {
        get { return array.Length; }

    }
}