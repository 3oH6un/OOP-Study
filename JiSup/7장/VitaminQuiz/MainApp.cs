namespace JiSup._7장.VitaminQuiz;

public static class StringExtension
{
    public static string Append(this string myStr,string a)
    {
        return myStr + a; //hello.Append로 들어왔음으로 myStr은 hello가 된다.
    }
}

public class MainApp
{
    

    public static void _Main(string[] args)
    {
        string hello = "Hello";
        Console.WriteLine(hello.Append(",World!")); //hello.append가 됬음으로 this sstring mystr은 hello의 변수값이 들어가고 retrun mystr+a가 됨으로 문자가 연결된다.
    }
}