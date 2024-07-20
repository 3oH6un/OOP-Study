namespace YongBin._8장.Interface;

using System;
using System.IO;

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
    private StreamWriter writer;                    // 버퍼

    public FileLogger(string path)
    {
        writer = File.CreateText(path);             // 텍스트 파일을 만들고
        writer.AutoFlush = true;                    // 버퍼에 있는 내용을 비우는 것
    }

    public void WriteLog(string message)
    {
        writer.WriteLine("{0} {1}", DateTime.Now.ToShortTimeString(), message);
    }
}

class ClimateMonitor
{
    private ILogger logger;

    public ClimateMonitor(ILogger logger)
    {
        this.logger = logger;
    }

    public void start()
    {
        while (true)
        {
            Console.Write("온도를 입력해주세요 : ");
            string temperature = Console.ReadLine();
            if(temperature == "")
                break;
            
            logger.WriteLog("현재 온도 : " + temperature);
        }
    }
}

public class MainApp
{
    static void Main_(string[] args)
    {
        ClimateMonitor monitor = new ClimateMonitor(
            new FileLogger("MyLog.txt"));                       // FileLogger 생성 후 ClimateMonitor 생성
        
        ClimateMonitor monitor2 = new ClimateMonitor(               // ConsoleLogger 생성 후 ClimateMonitor 생성
            new ConsoleLogger());
        
        monitor.start();
    }
}