using System.Collections;

namespace YongBin._10장.Yield;

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

public class MainApp
{
    static void Main_(string[] args)
    {
        var obj = new MyEnumerator();

        foreach (int i in obj)
        {
            Console.WriteLine(i);
        }
    }
}