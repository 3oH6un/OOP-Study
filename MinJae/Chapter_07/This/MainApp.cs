namespace MinJae.Chapter_07.This;

public class MainApp
{
    public static void _Main(string[] args)
    {
        Employee pooh = new Employee();
        pooh.SetName("Pooh");
        pooh.SetPosition("Waiter");
        Console.WriteLine($"{pooh.GetName()} {pooh.GetPosition()}");

        Employee tigger = new Employee();
        tigger.SetName("Tigger");
        tigger.SetPosition("Cleaner");
        Console.WriteLine($"{tigger.GetName()} {tigger.GetPosition()}");
    }
}

class Employee
{
    private string _name;
    private string _position;

    public void SetName(string name)
    {
        this._name = name;
    }

    public string GetName()
    {
        return this._name;
    }

    public void SetPosition(string position)
    {
        this._position = position;
    }

    public string GetPosition()
    {
        return this._position;
    }
}