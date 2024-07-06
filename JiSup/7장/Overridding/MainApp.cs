namespace JiSup._7장.Overridding;

class ArmorSuite
{
    public virtual void Initialize()
    {
        Console.WriteLine("Armored");
    }
}

class IronMan : ArmorSuite
{
    public override void Initialize()
    {
        base.Initialize();
        Console.WriteLine("Repulsor Rays Armed");
    }
}

class WarMachine : ArmorSuite
{
    public override void Initialize()
    {
        base.Initialize();
        Console.WriteLine("Double-Barrel Cannons Armed");
        Console.WriteLine("Micro-Rocket Launcher Armed");
    }
}

public class MainApp
{
    public static void _Main(string[] args)
    {
        Console.WriteLine("Creating ArmorSutie....");
        ArmorSuite armorsuite = new ArmorSuite();
        armorsuite.Initialize();

        Console.WriteLine("\nCreating IronMan....");
        ArmorSuite ironman = new IronMan();
        ironman.Initialize();
        
        Console.WriteLine("\nCreating WarMachine....");
        ArmorSuite warmachine = new WarMachine();
        warmachine.Initialize();
    }
}