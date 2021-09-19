using System;
using System.Collections.Generic;
using System.Text;

namespace WorldSync
{
    class ConsoleLogWriter : ILogWriter
    {
        public void LogInfo(string message)
        {
            Console.WriteLine($"{DateTime.Now:O}\tInfo\t{message}");
        }
        public void LogWarning(string message)
        {
            Console.WriteLine($"{DateTime.Now:O}\tWarning\t{message}");
        }
        public void LogError(string message)
        {
            Console.WriteLine($"{DateTime.Now:O}\tError\t{message}");
        }

        
    }
}
