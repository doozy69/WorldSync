using System;
using System.Collections.Generic;
using System.Text;

namespace WorldSync
{
    class MultipleLogWriter : ILogWriter
    {
        private ILogWriter[] arr;
        public MultipleLogWriter(params ILogWriter[] logs)
        {
            arr = logs;
        }

        public void LogError(string message)
        {
            foreach (ILogWriter item in arr)    item.LogError(message);
        }

        public void LogInfo(string message)
        {
            foreach (ILogWriter item in arr)    item.LogInfo(message);
        }

        public void LogWarning(string message)
        {
            foreach (ILogWriter item in arr)    item.LogWarning(message);
        }
    }
}
