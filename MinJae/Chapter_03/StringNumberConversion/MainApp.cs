namespace MinJae.Chapter_03.StringNumberConversion;

public class MainApp
{
    static void _Main(string[] args)
    {
        int a = 123;
        string b = a.ToString();
        Console.WriteLine($"int a = {a}");
        Console.WriteLine($"string b = a.ToString() = {b}");

        float c = 3.14f;
        string d = c.ToString();
        Console.WriteLine($"float c = {c}");
        Console.WriteLine($"string d = c.ToString() = {d}");

        string e = "123456";
        int f = Convert.ToInt32(e);
        Console.WriteLine($"string e = {e}");
        Console.WriteLine($"int f = Convert.ToInt32(e) = {f}");

        string g = "1.2345";
        float h = float.Parse(g);
        Console.WriteLine($"string g = {g}");
        Console.WriteLine($"float h = float.Parse(g) = {h}");
    }
}