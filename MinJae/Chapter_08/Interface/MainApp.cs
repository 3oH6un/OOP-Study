namespace MinJae.Chapter_08.Interface;

public class MainApp
{
    static void _Main(string[] args)
    {
        // ClimateMonitor monitor = new ClimateMonitor(new FileLogger("MyLog.txt"));
        ClimateMonitor monitor = new ClimateMonitor(new ConsoleLogger());

        monitor.Start();
    }
}

interface ILogger
{
    void WriteLog(string message);
}

class ConsoleLogger : ILogger
{
    public void WriteLog(string message)
    {
        Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
    }
}

class FileLogger : ILogger
{
    private StreamWriter _writer;

    public FileLogger(string path)
    {
        _writer = File.CreateText(path);
        _writer.AutoFlush = true;
    }

    public void WriteLog(string message)
    {
        _writer.WriteLine("{0} {1}", DateTime.Now.ToShortTimeString(), message);
    }
}

class ClimateMonitor(ILogger logger)
{
    private ILogger _logger = logger;

    public void Start()
    {
        while (true)
        {
            Console.WriteLine("온도를 입력해주세요.: ");
            string temperature = Console.ReadLine();

            if (temperature == "")
                break;

            _logger.WriteLog("현재 온도 : " + temperature);
        }
    }
}