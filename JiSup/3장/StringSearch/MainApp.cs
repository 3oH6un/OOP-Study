using static System.Console;
namespace JiSup._3장.StringSearch;

public class MainApp
{
    public static void Main__(string[] args)
    {
        string greeting = "Good Morning";

        WriteLine(greeting);
        WriteLine();

        //indefOf()
        WriteLine("IndeofOf 'Good' : {0} ", greeting.IndexOf("Good"));
        WriteLine("IndexOf 'o' : {0}", greeting.IndexOf('o'));
        
        //LastIndeoxOf()
        WriteLine("LastIndexOf 'Good' : {0}",greeting.IndexOf("Good"));
        WriteLine("LastIndexOf 'o' : {0}",greeting.LastIndexOf("o"));
        
        //StartWith()
        WriteLine("StartWish 'Good' : {0}",greeting.StartsWith("Good"));
        WriteLine("Startwish 'Morning' : {0}",greeting.StartsWith("Morning"));
        
        //EndWith()
        WriteLine("EndWith 'Good' : {0}",greeting.EndsWith("Good"));
        WriteLine("EndWith 'Morning : {0}",greeting.EndsWith("Morning"));
        
        //Contains()
        WriteLine("Contains 'Evening : {0}",greeting.Contains("Evening"));
        WriteLine("Contains 'Morning' : {0}",greeting.Contains("Morning"));
        
        //Replace()
        WriteLine("Replaced 'Morning' with 'Evening' : {0}",greeting.Replace("Morning","Evening"));
        
    }
}