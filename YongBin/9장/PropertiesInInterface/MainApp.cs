﻿namespace YongBin._9장.PropertiesInInterface;

interface IPropertiesInInterface
{
    interface INameValue
    {
        string Name
        {
            get;
            set;
        }

        string Value
        {
            get;
            set;
        }
    }
}

class NamedValue : IPropertiesInInterface.INameValue
{
    public string Name
    {
        get;
        set;
    }

    public string Value
    {
        get;
        set;
    }
}

public class MainApp
{
    static void Main_(string[] args)
    {
        NamedValue name = new NamedValue()
        {
            Name = "이름", Value = "박상현"
        };

        NamedValue height = new NamedValue()
        {
            Name = "키", Value = "177Cm"
        };

        NamedValue weight = new NamedValue()
        {
            Name = "몸무게", Value = "90Kg"
        };

        Console.WriteLine($"{name.Name} : {name.Value}");
        Console.WriteLine($"{height.Name} : {height.Value}");
        Console.WriteLine($"{weight.Name} : {weight.Value}");
    }
}