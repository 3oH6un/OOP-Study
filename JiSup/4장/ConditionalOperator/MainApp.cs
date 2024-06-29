namespace JiSup._4장.ConditionalOperator;

public class MainApp
{
    public static void Main__(string[] args)
    {
        string result = (10 % 2) == 0 ? "짝수" : "홀수";
        //삼항 연산자 -> 조건식 ? 참 값 : 거짓 값
        Console.WriteLine(result);
    }
}