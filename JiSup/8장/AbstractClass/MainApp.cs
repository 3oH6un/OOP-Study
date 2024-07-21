namespace JiSup._8장.AbstractClass;

abstract class AbstractBase
{
    protected void PrivateMethodA()
    {
        Console.WriteLine("AbstractBase.PrivateMethodA()");
    }

    public void publicMethodA()
    {
        Console.WriteLine("AbstractBase.publicMethodA()");
    }

    public abstract void AbstractMethodA();

}

class Derived : AbstractBase
{
    public override void AbstractMethodA()
    {
        Console.WriteLine("Derived.AbstractMethodA()");
        PrivateMethodA();
    }
}

public class MainApp
{
    public static void _Main(string[] args)
    {
        AbstractBase obj = new Derived();
        
        obj.AbstractMethodA();
        obj.publicMethodA();
    }
}