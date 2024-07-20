namespace MinJae.Chapter_07.Tuple;

public class MainApp
{
    static void _Main(string[] args)
    {
        (string, int) a = ("슈퍼맨", 9999);
        Console.WriteLine($"{a.Item1}, {a.Item2}");

        var b = (Name: "박상현", Age: 17);
        Console.WriteLine($"{b.Name}, {b.Age}");

        var (name, age) = b;
        Console.WriteLine($"{name}, {age}");

        var (name2, age2) = ("박문수", 34);
        Console.WriteLine($"{name2}, {age2}");

        b = a;
        Console.WriteLine($"{b.Name}, {b.Age}");
    }
}