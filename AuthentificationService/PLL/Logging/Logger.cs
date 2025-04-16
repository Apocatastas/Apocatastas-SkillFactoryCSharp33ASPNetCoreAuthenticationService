namespace AuthentificationService
{
    using global::AuthentificationService.Models;
    using System;
    using System.IO;
    using System.Threading;


    namespace AuthentificationService.Models
    {
        public class Logger : ILogger
        {
            private readonly string _logDirectory;
            private readonly string _eventsFilePath;
            private readonly string _errorsFilePath;
            private ReaderWriterLockSlim lock_ = new ReaderWriterLockSlim();


            public Logger()
            {
                // Создаем новую директорию для логов при каждом запуске приложения
                _logDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs", DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss"));
                Directory.CreateDirectory(_logDirectory);

                // Определяем пути к файлам для событий и ошибок
                _eventsFilePath = Path.Combine(_logDirectory, "events.txt");
                _errorsFilePath = Path.Combine(_logDirectory, "errors.txt");
            }
            public void WriteError(string errorMessage)
            {
                string message = $"{DateTime.Now}: {errorMessage}" + Environment.NewLine;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(message);
                Console.ForegroundColor = default;
                writeFile(_errorsFilePath, message);
            }

            public void WriteEvent(string eventMessage)
            {
                string message = $"{DateTime.Now}: {eventMessage}" + Environment.NewLine;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(message);
                Console.ForegroundColor = default;
                writeFile(_eventsFilePath, message);
            }

            void writeFile(string filePath, string message)
            {
                lock_.EnterWriteLock();
                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath, append: true))
                    {
                        writer.WriteLine(message);
                    }
                }
                finally
                {
                    lock_.ExitWriteLock();
                }
            }
        }
    }
}
