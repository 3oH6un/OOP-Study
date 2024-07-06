namespace YongBin._7장.MethodHiding;

class Base
{
    public void MyMethod()
    {
        Console.WriteLine("Base MyMethod()");
    }
}

class Derived : Base
{
    public new void MyMethod()
    {
        Console.WriteLine("Derived.MyMethod()");
    }
}

public class MainApp
{
    static void Main_(string[] args)
    {
        Base baseObj = new Base();
        baseObj.MyMethod();

        Derived derivedObj = new Derived();
        derivedObj.MyMethod();

        Base baseOrDerived = new Derived();
        baseOrDerived.MyMethod();
    }   
}