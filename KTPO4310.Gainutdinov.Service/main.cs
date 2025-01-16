using System;
using KTPO4310.Gainutdinov.Lib.src.LogAn; // Импортируем пространство имен для LogAnalyzer

namespace KTPO4310.Gainutdinov.Service
{
    public class MainEntry
    {
        public static void Main(string[] args)
        {
            LogAnalyzer logAnalyzer = new LogAnalyzer();

            // Примеры имен файлов для проверки
            string[] fileNames =
            {
                "logfile.log",     // Правильное расширение
                "document.txt",    // Правильное расширение
                "report.log",      // Правильное расширение
                "picture.png",       // Неправильное расширение
                "archive.zip",     // Неправильное расширение
                "notes.doc"        // Неправильное расширение
            };

            foreach (var fileName in fileNames)
            {
                bool isValid = logAnalyzer.IsValidLogFileName(fileName);
                Console.WriteLine($"Файл '{fileName}' имеет допустимое расширение: {isValid}");
            }
        }
    }
}
