namespace YongBin._8장;

abstract class AbstractBase
{
    protected void PrivateMethodA()
    {
        Console.WriteLine("AbstractBa'se.ProtectedMethodA()");
    }

    public void PublicMethodA()
    {
        Console.WriteLine("AbstractBase.PublicMethodA()");
    }

    public abstract void AbstractMethodA();
}

class Derived : AbstractBase
{
    public override void AbstractMethodA()
    {
        Console.WriteLine("Derived.AbstractMethod()");
        PrivateMethodA();
    }
}

public class AbstractClass
{
    static void Main_(string[] args)
    {
        AbstractBase obj = new Derived();
        obj.AbstractMethodA();
        obj.PublicMethodA();
    }
}