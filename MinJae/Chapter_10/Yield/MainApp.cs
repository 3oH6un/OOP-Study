using System.Collections;

namespace MinJae.Chapter_10.Yield;

public class MainApp
{
    static void _Main(string[] args)
    {
        var obj = new MyEnumerator();
        foreach (int i in obj)
        {
            Console.WriteLine(i);
        }
    }
}

class MyEnumerator
{
    int[] numbers = { 1, 2, 3, 4 };

    public IEnumerator GetEnumerator()
    {
        yield return numbers[0];
        yield return numbers[1];
        yield return numbers[2];
        yield break;
        yield return numbers[3];
    }
}