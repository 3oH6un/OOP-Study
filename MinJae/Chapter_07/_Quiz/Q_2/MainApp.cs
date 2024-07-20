namespace MinJae.Chapter_07._Quiz.Q_2;

public class MainApp
{
    static void _Main(string[] args)
    {
        string hello = "hello";
        Console.WriteLine(hello.Append(", World!"));
    }
}

static class StringExtension
{
    public static string Append(this string myString, string text)
    {
        return myString + text;
    }
}