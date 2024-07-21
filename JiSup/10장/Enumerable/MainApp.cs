namespace JiSup._10장.Enumerable;
using System.Collections;

class Mylist : IEnumerable, IEnumerator
{
    private int[] array;
    private int position = -1;

    public Mylist()
    {
        array = new int[3];
    }

    public int this[int index]
    {
        get
        {
            return array[index];
        }

        set
        {
            if (index >= array.Length)
            {
                Array.Resize<int>(ref array, index +1);
                Console.WriteLine($"Array Resized : {array.Length}");
            }

            array[index] = value;
        }
        
    }

    public object Current
    {
        get
        {
            return array[position];
        }
    }

    public bool MoveNext()
    {
        if (position == array.Length - 1)
        {
            Reset();
            return false;
        }

        position++;
        return (position < array.Length);
    }

    public void Reset()
    {
        position = -1;
    }

    public IEnumerator GetEnumerator()
    {
        return this;
    }
    
}

public class MainApp
{
    public static void Main(string[] args)
    {
        Mylist list = new Mylist();
        for (int i = 0; i < 5; i++)
        {
            list[i] = i;
        }

        foreach (int e in list)
        {
            Console.WriteLine(e);
        }
    }
}