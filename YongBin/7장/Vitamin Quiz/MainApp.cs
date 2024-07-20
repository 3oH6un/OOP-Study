namespace YongBin._7장.Vitamin_Quiz;

public static class StringExtension
{
    public static string Append(this string myString, string plus)
    {
        return myString + plus;
    }
}

public class MainApp
{
    static void Main_(string[] args)
    {
        string hello = "Hello";
        
        Console.WriteLine(hello.Append(", World!"));
    }
}