using static System.Console;
namespace JiSup._3장.StringSlice;

public class MainApp
{
    public static void Main_(string[] args)
    {
        string greeting = "Good morning.";
        
        WriteLine(greeting.Substring(0,5)); //0번째 위치에서 5번째 까지 문자열을 자른다.
        WriteLine(greeting.Substring(5));   //5번째 위치에서 맨끝까지 문자열을 자른다.
        WriteLine();

        greeting = "Good Morning Every One";
        string[] arr = greeting.Split(new string[] { " " }, StringSplitOptions.None);//new string[]{  } 중괄호 값을 기준으로 잘라서 배열에 대입
        WriteLine("Word Count : {0}",arr.Length);   

        foreach (string element in arr) 
            WriteLine("{0}",element);
        

    }
}