using System.Collections;

namespace YongBin._10장.Enumerable;

class MyList : IEnumerable, IEnumerator
{
    private int[] array;
    private int position = -1;

    public MyList()
    {
        array = new int[3];             
    }

    public int this[int index]
    {
        get
        {
            return array[index];                
        }

        set                                     // for문
        {
            if (index >= array.Length)
            {
                Array.Resize<int>(ref array, index + 1);
                Console.WriteLine($"Array Resized : {array.Length}");
            }

            array[index] = value;
        }
    }
    
    // IEnumerator 멤버
    public object Current               // for-each 문 3)
    {
        get
        {
            // return this[position];
            return array[position];
        }
    }
    
    // IEnumerator 멤버
    public bool MoveNext()              // for-each 문 2) / 조건검사
    {
        if (position == array.Length - 1)               // 같을 경우
        {
            Reset();                                    
            return false;                               // 종료
        }
        position++;

        return (position < array.Length);
    }
    
    // IEnumerator 멤버
    public void Reset()                 
    {
        position = -1;
    }
    
    // IEnumerator 멤버
    public IEnumerator GetEnumerator()      // for-each 문 1) / 처음 시작 한번만 동작
    {
        return this;
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

        foreach (int e in list)
        {
            Console.WriteLine(e);  
        }
    }
}