namespace JiSup._10장.Indexer;

class Mylist
{
    private int[] array;

    public Mylist()
    {
        array = new int[3];
    }
    
    //Mylist 인스턴스 index값 지정
    //this = array[];
    //this[int index] = array[index]; index이름은 변수임으로 아무값이나 써도 상관없다.
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
                Array.Resize<int>(ref array, index + 1);
                Console.WriteLine("Array Resized : {0}", array.Length);
            }

            array[index] = value;
        }
    }

    public int Length
    {
        get { return array.Length; }
    }
}

public class MainApp
{
    public static void _Main(string[] args)
    {
        Mylist list = new Mylist();
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