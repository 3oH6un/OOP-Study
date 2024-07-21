namespace MinJae.Chapter_08.AbstractClass;

public class MainApp
{
    static void _Main(string[] args)
    {
        AbstractBase obj = new Derived();
        obj.AbstractMethodA();
        obj.PublicMethodA();
    }
}

abstract class AbstractBase
{
    protected void ProtectedMethodA()
    {
        Console.WriteLine("AbstractBase.ProtectedMethodA");
    }

    public void PublicMethodA()
    {
        Console.WriteLine("AbstractBase.PublicMethodA");
    }

    public abstract void AbstractMethodA();
}

class Derived : AbstractBase
{
    public override void AbstractMethodA()
    {
        Console.WriteLine("Derived.AbstractMethodA()");
        ProtectedMethodA();
    }
}