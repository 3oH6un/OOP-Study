namespace JiSup._3장.BoxingUnboxing;

public class MainApp
{
    
    public static void Main__(string[] args)
    {
        int a = 123;
        object b = (object)a; //객체로 변환해서 저장하는 방식이 Boxing이다. object는 참조형식을 저장할 수 있음으로 참조형식이다.
        int c = (int)b; //object탑입인 b를 값형식으로 저장하는것을 UnBoxing이라 한다.

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        
        double x = 3.1414213;   //값형식 Double
        object y = x;           //참조형식 object Boxing
        double z = (double)y;   //값 형식 UnBoxing

        //스택에 저장되어야 하는 값을 힙에다 저장할 경우 Boxing
        //힙에 있어야하는것을 스택에 저장하면 UnBoxing
        
        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(z);

    }
    
}