using static System.Console;using System.Collections;

namespace JiSup._4장.NullConditionalOperator;
//NULL 조건부 연산자 활용
public class MainApp
{
    public static void Main__(string[] args)
    {
        ArrayList a = null; //a가 null값임으로 메모리 주소를 못받았음으로 출력을안함 
        a?.Add("야구");    //위와 같이 null 값임으로 null값을 반환  
        a?.Add("축구");
        WriteLine($"Count : {a?.Count}");
        WriteLine($"{a?[0]}");
        WriteLine($"{a?[1]}");

        a = new ArrayList(); //a가 메모리 주소를 받았음으로 add로 값을 넣어서 출력
        a?.Add("야구");   //null값이 아님으로 a의 리스트에  Add("야구")가 실행되어서 a[0]은 "야구" 가 된다.
        a?.Add("축구");
        WriteLine($"Count : {a?.Count}");
        WriteLine($"{a?[0]}");
        WriteLine($"{a?[1]}");
    }
}