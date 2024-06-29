using static System.Console;
namespace JiSup._3장.StringModify;

public class MainApp
{
    public static void Main_(string[] args)
    {
        WriteLine("ToLower() : '{0}'","ABC".ToLower());
        WriteLine("ToUpeer() : '{0}'","abc".ToUpper());
        
        WriteLine("Insert() : '{0}'","Happy Friday!".Insert(5,"Sunny"));
        WriteLine("Remove() : '{0}'","I Don't Love You.".Remove(2,6));
        
        WriteLine("Trim() : '{0}'"," No Spaces ".Trim());
        WriteLine("TrimStart() : '{0}'"," No Spaces ".TrimStart());
        WriteLine("TrimEnd() : '{0}'"," No Spaces ".TrimEnd());
        
    }
}