
namespace JiSup._10장.Yield;
using System.Collections;


class MyEnumerator
{
    private int[] numbers = { 1, 2, 3, 4 };

    public IEnumerator GetEnumerator()
    {
        yield return numbers[0];
        yield return numbers[1];
        yield return numbers[2];
        yield break;
        yield return numbers[2];
        
    }
}

public class MainApp
{
    public static void _Main(string[] args)
    {
        var obj = new MyEnumerator();
        foreach (int i in obj)
        {
            Console.WriteLine(i);
        }
    }   
}