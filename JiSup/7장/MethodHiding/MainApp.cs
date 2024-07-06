namespace JiSup._7장.MethodHiding;

class Base
{
    public void MyMethod()
    {
        Console.WriteLine("Base.MyMethod()");
    }
}

class Derived : Base
{
    public new void MyMethod() //new 키워드를 사용 상속된 MyMethod()를 Base.MyMethod를 숨기고 새로 MyMethod를 구현
                               //출력은 Derived MyMethod호출
    {
        Console.WriteLine("Derived.MyMethod()");
    }
}

public class MainApp
{
    public static void _Main(string[] args)
    {
        Base baseobj = new Base();
        baseobj.MyMethod();

        Derived derivedobj = new Derived();
        derivedobj.MyMethod();

        Base baseOrDerived = new Derived();
        baseOrDerived.MyMethod();   //Base타입으로 Derived객체를 생성하였음으로 Derived의 Base들만 인스턴화되고 나머지는 가려진다.
                                    //따라서 Derived의 MyMethod는 가려졌음으로 Base의 MyMethod가 출력됨.

    }
}