using System;

namespace Interface;

public class DatabaseLogger : ILogger
{
    public void WriteLog()
    {
        Console.WriteLine("Veritabanına yazar");
    }
}
