using System;
using System.IO;
namespace SimbirSoftProj.Core.Log
{
    public static class Logger
    {
        public static void WriteLog(string message)
        {
            string logPath = "LogFile.txt";

            using (StreamWriter writer = new StreamWriter(logPath, true))
            {
                writer.WriteLine($"[{DateTime.Now}] : {message}");
            }
        }
    }
}
