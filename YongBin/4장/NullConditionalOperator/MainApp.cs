using System.Collections;
using static System.Console;

namespace YongBin._4장.NullConditionalOperator;

public class MainApp
{
    public static void Main(string[] args)
    {
        ArrayList a = null;

        a?.Add("야구");       // a?.가 null을 반환하므로 Add() 메소드는 호출 X / a가 null이 아닐 경우에는 Add()메서드 호출
        a?.Add("축구");

        WriteLine($"Count : {a?.Count}");           // a?.가 null을 반환하므로 'Count : ' 외에는 아무것도 출력 X 
        WriteLine($"{a?[0]}");                      // a?.가 null을 반환하므로 WriteLine()만 호출하여 줄바꿈
        WriteLine($"{a?[1]}");                      // a?.가 null을 반환하므로 WriteLine()만 호출하여 줄바꿈

        a = new ArrayList();        // a는 더 이상 null이 X
        
        a?.Add("야구");
        a?.Add("축구");
        
        WriteLine($"Count : {a?.Count}");           // a?.이 null이 아니므로 Count 정상 호출
        WriteLine($"{a?[0]}");                      // a?.이 null이 아니므로 a?[0] 출력
        WriteLine($"{a?[1]}");                      // a?.이 null이 아니므로 a?[1] 출력\

        int d = 0xF0 | 0x0F;
        WriteLine(d);
    }
}