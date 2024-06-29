namespace JiSup._5장.Break;

public class MainApp
{
    public static void Main__(string[] args)
    {
        while (true)
        {
            Console.WriteLine("계속할까요?(예:아니오) : ");
            string answer = Console.ReadLine();

            if (answer == "아니오")
            {
                break;
                
            }
            //break 사용 반복문 하나를 나간다.  while(true)하나 밖에 없음으로 하나만 나간다.

        }
    }
}