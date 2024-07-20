namespace MinJae.Chapter_08.DefaultImplementation;

public class MainApp
{
    static void _Main(string[] args)
    {
        ILogger logger = new ConsoleLogger();
        logger.WriteLog("System Up");
        logger.WriteError("System Fail");

        ConsoleLogger clogger = new ConsoleLogger();
        clogger.WriteLog("System Up");
        // clogger.WriteError("Ststem Fail");
    }
}

interface ILogger
{
    void WriteLog(string message);

    void WriteError(string error)
    {
        WriteLog($"Error: {error}");
    }
}

class ConsoleLogger : ILogger
{
    public void WriteLog(string message)
    {
        Console.WriteLine($"{DateTime.Now.ToLocalTime()}, {message}");
    }
}