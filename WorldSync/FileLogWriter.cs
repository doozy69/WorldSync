using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WorldSync
{
    class FileLogWriter : ILogWriter
    {
        private readonly string _path = "Log.txt";
        public FileLogWriter() { }
        public FileLogWriter(string path)
        {
            _path = path;
        }
        public void LogInfo(string message)
        {
            FileSave($"{DateTime.Now:O}\tInfo\t{message}");
        }
        public void LogWarning(string message)
        {
            FileSave($"{DateTime.Now:O}\tWarning\t{message}");
        }
        public void LogError(string message)
        {
            FileSave($"{DateTime.Now:O}\tError\t{message}");
        }
        private void FileSave(string message)
        {
            try
            {
                StreamWriter sw = new StreamWriter(_path, true);
                sw.WriteLine(message);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
        
    }
}
