using static System.Console;using System.Collections;

namespace JiSup._4장.NullConditionalOperator;

public class MainApp
{
    public static void Main(string[] args)
    {
        ArrayList a = null; //a가 null값임으로 메모리 주소를 못받았음으로 출력을안함 
        a?.Add("야구");
        a?.Add("축구");
        WriteLine($"Count : {a?.Count}");
        WriteLine($"{a?[0]}");
        WriteLine($"{a?[1]}");

        a = new ArrayList(); //a가 메모리 주소를 받았음으로 add로 값을 넣어서 출력
        a?.Add("야구");
        a?.Add("축구");
        WriteLine($"Count : {a?.Count}");
        WriteLine($"{a?[0]}");
        WriteLine($"{a?[1]}");
    }
}