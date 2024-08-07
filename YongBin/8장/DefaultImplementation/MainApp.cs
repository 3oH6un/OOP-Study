﻿namespace YongBin._8장.DefaultImplementation;

interface ILogger
{
    void WriteLog(string message);

    void WriteError(string error)               // 새로운 메소드 추가
    {   
        WriteLog($"Error : {error}");           //
    }
}

class ConsoleLogger : ILogger
{
    public void WriteLog(string message)
    {
        Console.WriteLine($"{DateTime.Now.ToLocalTime()}, {message}");
    }
}

public class MainApp
{
    static void Main_(string[] args)
    {
        ILogger logger = new ConsoleLogger();
        logger.WriteLog("System Up");
        logger.WriteError("System Fail");

        ConsoleLogger clogger = new ConsoleLogger();
        clogger.WriteLog("System Up");          // OK
//      clogger.WriteError("System Fail");      // 컴파일 에러
    }
}