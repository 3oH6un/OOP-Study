using static System.Console;
namespace JiSup._3장.StringSearch;

public class MainApp
{
    public static void Main_(string[] args)
    {
        string greeting = "Good Morning";

        WriteLine(greeting);
        WriteLine();
        
        //indefOf() 
        WriteLine("IndeofOf 'Good' : {0} ", greeting.IndexOf("Good"));
        WriteLine("IndexOf 'o' : {0}", greeting.IndexOf('o'));
        //String 배열의 값.IndexOf("") 소괄호안의 문자값을 기준으로 인덱스 위치를 찾는다.
        
        //LastIndexOf()
        WriteLine("LastIndexOf 'Good' : {0}",greeting.IndexOf("Good")); 
        WriteLine("LastIndexOf 'o' : {0}",greeting.LastIndexOf("o"));   
        //String 배열의 값.LastIndexOf("") 소괄호안의 문자값을 기준으로 뒤에서부터 Index위치를 찾는다.
        
        //StartWith()
        WriteLine("StartWish 'Good' : {0}",greeting.StartsWith("Good"));
        WriteLine("Startwish 'Morning' : {0}",greeting.StartsWith("Morning"));
        //현재 문자열 값이 지정된 문자열로 시작하는지 참 거짓을 판단
        
        //EndWith()
        WriteLine("EndWith 'Good' : {0}",greeting.EndsWith("Good"));
        WriteLine("EndWith 'Morning : {0}",greeting.EndsWith("Morning"));
        //현재 문자열이 지정된 문자열로 끝나는지 참 거짓을 판단
        
        //Contains()
        WriteLine("Contains 'Evening : {0}",greeting.Contains("Evening"));
        WriteLine("Contains 'Morning' : {0}",greeting.Contains("Morning"));
        //현재 문자열이 지정된 문자열이 포함되는지 참 거짓을 판단
        
        //Replace()
        WriteLine("Replaced 'Morning' with 'Evening' : {0}",greeting.Replace("Morning","Evening"));
        //현재 문자열의 값을 지정한 문자열의 값으로 바꾼다.
        
    }
}