using System.Security.Cryptography;

namespace JiSup._7장.Tuple;

public class MainApp
{
    public static void _Main(string[] args)
    {
        //명명되지 않은 튜플
        var a = ("슈퍼맨", 9999);
        Console.WriteLine($"{a.Item1}, {a.Item2}");
        //var말고 직접 지정해서 (string,int로 지정하면 직접 지정할 수 있음)
        //ex) (string,int) a = ("슈퍼맨", 9999);
        //ex) (string name,int age) a = ("슈퍼맨", 9999);
        
        //명명된 튜플
        var b = (Name: "박상현", Age: 17);
        Console.WriteLine($"{b.Name}, {b.Age}");

        //분해
        var (name, age) = b;
        Console.WriteLine($"{name},, {age}");

        //분해2
        var (name2, age2) = ("박문수", 34);
        Console.WriteLine($"{name2},{age2}");

        //명명된 튜플 = 명명되지 않은 튜플
        b = a;
        Console.WriteLine($"{b.Name}, {b.Age}");
        

    }    
}