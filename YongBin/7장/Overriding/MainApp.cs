using System;
namespace YongBin._7장.Overriding;

class ArmorSuite
{
    public virtual void Initialize()
    {
        Console.WriteLine("Armored");
    }
}

class IronMain : ArmorSuite
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
    static void Main_(string[] args)
    {
        Console.WriteLine("Creating ArmorSuite...");
        ArmorSuite armorsuite = new ArmorSuite();
        armorsuite.Initialize();

        Console.WriteLine("\nCreating IronMan...");
        ArmorSuite ironman = new IronMain();
        ironman.Initialize();

        Console.WriteLine("\nCreating WarMachine...");
        ArmorSuite warmachine = new WarMachine();
        warmachine.Initialize();
    }
}