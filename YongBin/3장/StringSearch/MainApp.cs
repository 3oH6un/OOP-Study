﻿using static System.Console;                // Console은 static을 붙여줘야 함!
namespace YongBin._3장.StringSearch;

public class MainApp
{
    public static void Main_(string[] args)
    {
        string greeting = "Good Morning";

        WriteLine(greeting);
        WriteLine();
        
        // IndexOf()
        WriteLine("IndexOf 'Good' : {0}", greeting.IndexOf("Good"));
        WriteLine("IndexOf 'o' : {0}", greeting.IndexOf("o"));
        
        // LastIndexOf()
        WriteLine("LastIndexOf : 'Good' : {0}", greeting.LastIndexOf("Good"));
        WriteLine("LastIndexOf : 'o' : {0}", greeting.LastIndexOf("o"));
        
        // StartsWith()
        WriteLine("StartsWith 'Good' : {0}", greeting.StartsWith("Good"));
        WriteLine("StartsWith 'Morning : {0}", greeting.StartsWith("Morning"));
        
        // EndWith()
        WriteLine("EndWith 'Good' : {0}", greeting.EndsWith("Good"));
        WriteLine("EndWith 'Morning' : {0}", greeting.EndsWith("Morning"));
        
        // Contains()
        WriteLine("Contains 'Evening' : {0}", greeting.Contains("Evening"));
        WriteLine("Contains 'Morning' : {0}", greeting.Contains("Morning"));
        
        // Replace()
        WriteLine("Replaced 'Morning' with 'Evening' : {0}", greeting.Replace("Morning", "Evening"));
    }   
}