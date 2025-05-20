using System;
using System.IO;
using System.Threading;

namespace RulesEngine
{
    public class Logger
    {
        private static ReaderWriterLockSlim _readWriteLock = new ReaderWriterLockSlim();

        public static void Log(string logDetails, bool logToFile = true, bool logToRoot = false)
        {
            string path;

            if (logToRoot)
            {
                path = AppDomain.CurrentDomain.BaseDirectory + "\\Logs";
            }
            else
            {
                path = $@"C:\ThreatLocker\RulesEngineLogs";
            }

            string logFilePath = $"{path}\\log_{DateTime.Today:yyyyMMdd}.txt";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            try
            {
                string entry = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss") + " " + logDetails;

                Console.WriteLine(entry);

                if (logToFile)
                {
                    LogToFile(logFilePath, entry);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Logging to Log File");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        private static void LogToFile(string logFilePath, string entry)
        {
            // Set Status to Locked
            _readWriteLock.EnterWriteLock();

            try
            {
                // Append text to the file
                using (StreamWriter sw = File.AppendText(logFilePath))
                {
                    sw.WriteLine(entry);
                    sw.Close();
                }
            }
            finally
            {
                // Release lock
                _readWriteLock.ExitWriteLock();
            }
        }
    }
}
