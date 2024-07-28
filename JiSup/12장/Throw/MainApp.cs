﻿namespace JiSup._12장.Throw;

public class MainApp
{
    static void DoSomething(int arg)
    {
        if (arg < 10)
        {
            Console.WriteLine($"arg : {arg}");
        }
        else
        {
            throw new Exception("arg가 10보다 큽니다.");
        }
    }

    public static void _Main(string[] args)
    {
        try
        {
            DoSomething(1);
            DoSomething(3);
            DoSomething(5);
            DoSomething(9);
            DoSomething(11);
            DoSomething(13);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            
        }
    }
}