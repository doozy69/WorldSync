using System;

namespace WorldSync
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogWriter fileLog = new FileLogWriter();
            fileLog.LogInfo("FileLogWriterInfo");
            fileLog.LogWarning("FileLogWriterWarning");
            fileLog.LogError("FileLogWriterError");

            ILogWriter consoleLog = new ConsoleLogWriter();
            consoleLog.LogInfo("ConsoleLogWriterInfo");
            consoleLog.LogWarning("ConsoleLogWriterWarning");
            consoleLog.LogError("ConsoleLogWriterError");

            ILogWriter multilog = new MultipleLogWriter(fileLog, consoleLog);
            multilog.LogInfo("MultipleLogWriterInfo");
            multilog.LogWarning("MultipleLogWriterWarning");
            multilog.LogError("MultipleLogWriterError");
        }
    }
}
