﻿namespace YongBin._5장.Continue;

public class MainApp
{
    public static void Main_(string[] args)
    {
        for (int i = 0; i < 10; i++)
        {
            if(i % 2 == 0)
                continue;

            Console.WriteLine($"{i} : 홀수");
        }
    }
}