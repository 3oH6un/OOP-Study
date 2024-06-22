using static System.Console;

namespace MinJae.Chapter_03.StringSearch;

public class MainApp
{
    static void _Main(string[] args)
    {
        string greeting = "Good Morning";

        WriteLine(greeting);
        WriteLine();

        // IndexOf() : 문자열에서 특정 문자열이 처음으로 나타나는 위치를 반환
        WriteLine("IndexOf 'Good' : {0}", greeting.IndexOf("Good"));
        WriteLine("IndexOf 'o : {0}'", greeting.IndexOf("o"));

        // LastIndexOf() : 문자열에서 특정 문자열이 마지막으로 나타나는 위치를 반환
        WriteLine("LastIndexOf 'Good' : {0}", greeting.LastIndexOf("Good"));
        WriteLine("LastIndexOf 'o' : {0}", greeting.LastIndexOf("o"));

        // StartsWith() : 문자열이 특정 문자열로 시작하는지 여부를 반환
        WriteLine("StartsWith 'Good' : {0}", greeting.StartsWith("Good"));
        WriteLine("StartsWith 'Morning' : {0}", greeting.StartsWith("Morning"));

        // EndsWith() : 문자열이 특정 문자열로 끝나는지 여부를 반환
        WriteLine("EndsWith 'Good' : {0}", greeting.EndsWith("Good"));
        WriteLine("EndsWith 'Morning' : {0}", greeting.EndsWith("Morning"));

        // Contains() : 문자열이 특정 문자열을 포함하는지 여부를 반환
        WriteLine("Contains 'Evening' : {0}", greeting.Contains("Evening"));
        WriteLine("Contains 'Morning' : {0}", greeting.Contains("Morning"));

        // Replace() : 문자열 내의 특정 문자열을 다른 문자열로 변경
        WriteLine("Replace 'Morning' with 'Evening' : {0}", greeting.Replace("Morning", "Evening"));
    }
}