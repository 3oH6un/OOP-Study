namespace JiSup._8장.MultiInterfaceInheritance;

//C#에서는 다중상속을 지원할 경우 죽음의 다이아몬드 문제가 발생하기 때문에 지원하지 않는다
//inferface는 멤버의 형태만 전달하기 때문에 오버라이딩을 해야함 그래서 다중상속이 가능하다.
interface IRunnable
{
    void Run();
}

interface IFlyable
{
    void Fly();
}

class FlyingCar : IRunnable, IFlyable
{
    public void Run()
    {
        Console.WriteLine("Run! Run!");
    }

    public void Fly()
    {
        Console.WriteLine("Fly! Fly!");
    }
}

public class MainApp
{
    public static void _Main(string[] args)
    {
        FlyingCar car = new FlyingCar();
        car.Run();
        car.Fly();
        
        IRunnable runnable = car as IRunnable;
        runnable.Run();
        
        IFlyable flyable = car as IFlyable;
        flyable.Fly();
    }
}