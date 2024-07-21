namespace YongBin._10장.Indexer;

class MyList
{
    private int[] array;

    public MyList()
    {
        array = new int[3];
    }

    public int this[int index]                      // 만들어진 인스턴스한테 인덱스가 붙어져서 들어올 경우 처리
    {
        get
        {
            return array[index];
        }
        set
        {
            if (index >= array.Length)              // 처리할 내용
            {
                Array.Resize<int>(ref array, index + 1);
                Console.WriteLine($"Array Resized : {array.Length}");
            }

            array[index] = value;
        }
    }
    
    public int Length
    {
        get {
            return array.Length; 
        }
    }
}



public class MainApp
{
    static void Main_(string[] args)
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