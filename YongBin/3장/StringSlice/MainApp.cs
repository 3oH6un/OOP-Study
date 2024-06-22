using System;
using static System.Console;
namespace YongBin._3장.StringSlice;

public class MainApp
{
    public static void Main_(string[] args)
    {
        string greeting = "Good morning.";
        
        WriteLine(greeting.Substring(0, 5));
        WriteLine(greeting.Substring(5));
        WriteLine();

        string[] arr = greeting.Split(
            new string[] {" "}, StringSplitOptions.None);
        WriteLine("Word Count : {0}", arr.Length);

        foreach (string element in arr)
        {
            WriteLine("{0}", element);
        }
    }
}