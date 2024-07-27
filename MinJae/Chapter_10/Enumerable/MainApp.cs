using System.Collections;

namespace MinJae.Chapter_10.Enumerable;

public class MainApp
{
    static void _Main(string[] args)
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

class MyList : IEnumerable, IEnumerator
{
    private int[] _array;
    private int _position = -1;

    public MyList()
    {
        _array = new int[3];
    }

    public int this[int index]
    {
        get { return _array[index]; }
        set
        {
            if (index >= _array.Length)
            {
                Array.Resize<int>(ref _array, index + 1);
                Console.WriteLine($"Array Resized : {_array.Length}");
            }

            _array[index] = value;
        }
    }

    public object Current
    {
        get { return _array[_position]; }
    }


    public bool MoveNext()
    {
        if (_position == _array.Length - 1)
        {
            Reset();
            return false;
        }

        _position++;
        return (_position < _array.Length);
    }

    public void Reset()
    {
        _position = -1;
    }

    public IEnumerator GetEnumerator()
    {
        return this;
    }
}