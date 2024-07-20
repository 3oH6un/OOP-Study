using JiSup._8장.Interface;

namespace JiSup._8장.DefaultImplementation;

interface Ilogger
{
    void WriteLog(string message);

    void WriteError(string error)
    {
        WriteLog($"Error : {error}");
    }
}

class ConsoleLogger : Ilogger
{
    public void WriteLog(string message)
    {
        Console.WriteLine($"{DateTime.Now.ToLocalTime()},{message}");
    }
}

public class MainApp
{
    public static void _Main(string[] args)
    {
        Ilogger logger = new ConsoleLogger();
        logger.WriteLog("System Up");
        logger.WriteError("System Fail");

        ConsoleLogger clogger = new ConsoleLogger();
        clogger.WriteLog("System Up1S");
        // clogger.WriteError("System Fail");
    }
}