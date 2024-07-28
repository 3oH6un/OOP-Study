using System.Collections;
using System;
using System.Collections.Generic;

namespace MinJae.Chapter_11.EnumerableGeneric;

public class MainApp
{
    static void _Main(string[] args)
    {
        MyList<string> str_list = new MyList<string>();

        str_list[0] = "abc";
        str_list[1] = "def";
        str_list[2] = "ghi";
        str_list[3] = "jkl";
        str_list[4] = "mno";

        foreach (string str in str_list)
        {
            Console.WriteLine($"{str}");
        }

        Console.WriteLine();

        MyList<int> int_list = new MyList<int>();

        int_list[0] = 0;
        int_list[1] = 1;
        int_list[2] = 2;
        int_list[3] = 3;
        int_list[4] = 4;

        foreach (int no in int_list)
        {
            Console.WriteLine(no);
        }
    }

    public void Test()
    {
        File.Open("asdf", FileMode.Open);
    }
}

class MyList<T> : IEnumerable<T>, IEnumerator<T>
{
    private T[] _array;
    private int _position = -1;

    public MyList()
    {
        _array = new T[3];
    }

    public T this[int index]
    {
        get { return _array[index]; }
        set
        {
            if (index >= _array.Length)
            {
                Array.Resize<T>(ref _array, index + 1);
                Console.WriteLine($"Array Resized : {_array.Length}");
            }

            _array[index] = value;
        }
    }

    public int Length
    {
        get { return _array.Length; }
    }

    public IEnumerator<T> GetEnumerator() { return this; }

    IEnumerator IEnumerable.GetEnumerator() { return this; }

    public T Current
    {
        get { return _array[_position]; }
    }

    object IEnumerator.Current
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

    public void Dispose()
    {

    }
}