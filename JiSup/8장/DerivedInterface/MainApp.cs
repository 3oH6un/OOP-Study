namespace JiSup._8장.DerivedInterface;

interface Ilogger
{
    void WriteLog(string message);
}

interface IFormattableLogger : Ilogger
{
    void WriteLog(string format, params Object[] args);
}

class ConsoleLogger2 : IFormattableLogger
{
    public void WriteLog(string message)
    {
        Console.WriteLine("{0} {1}",DateTime.Now.ToLocalTime(), message);
    }

    public void WriteLog(string format, params Object[] args)
    {
        String message = String.Format(format, args);
        Console.WriteLine("{0} {1}",DateTime.Now.ToLocalTime(), message);
    }
    
}

public class MainApp
{
    public static void _Main(string[] args)
    {
        IFormattableLogger logger = new ConsoleLogger2();
        
        logger.WriteLog("The world is not flat.");
        logger.WriteLog("{0} + {1} = {2}",1,1,2);
    }
}