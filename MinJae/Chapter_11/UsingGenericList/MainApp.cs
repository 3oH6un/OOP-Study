namespace MinJae.Chapter_11.UsingGenericList;

using System;
using System.Collections.Generic;

public class MainApp
{
    static void _Main(string[] args)
    {
        List<int> list = new List<int>();
        for (int i = 0; i < 5; i++)
            list.Add(i);

        foreach (int element in list)
        {
            Console.Write($"{element} ");
        }

        Console.WriteLine();
        list.RemoveAt(2);

        foreach (int element in list)
        {
            Console.Write($"{element} ");
        }

        Console.WriteLine();
        list.Insert(2, 2);

        foreach (int element in list)
        {
            Console.Write($"{element} ");
        }

        Console.WriteLine();
    }
}

