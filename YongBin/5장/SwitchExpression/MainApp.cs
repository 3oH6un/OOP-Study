namespace YongBin._5장.SwitchExpression;

public class MainApp
{
    public static void Main_(string[] args)
    {
        int input = Convert.ToInt32(Console.ReadLine());        // null이 들어오면 0을 반환 
        
        // 1의 자리를 버림. ex) 92 -> 90, 87 -> 80
        int score = (int)(Math.Truncate(input / 10.0) * 10);

        string grade = score switch
        {
            90 => "A",
            80 => "B",
            70 => "C",
            60 => "D",
            _ => "F"
        };

        Console.WriteLine(grade);
    }
}