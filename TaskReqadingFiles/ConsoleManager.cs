namespace TaskReadingFiles
{
    public static class ConsoleManager
    {
        public static void PrintHello() 
        {
            Console.WriteLine("\n\nПривет! Это программа по параллельному считыванию файлов из директории\n\n");
        }

        /// <summary>
        /// Получение полного пути директории из консоли
        /// </summary>
        /// <returns></returns>
        public static string GetDirrectoryPath()
        {
            Console.Write("\nВведите полный адрес директории: ");
            var dir = Console.ReadLine()?.Trim();
            return dir;
        }

        /// <summary>
        /// Печать в консоль результата для пустых и ПРОБЕЛЬНЫХ файлов
        /// </summary>
        /// <param name="fileName"></param>
        public static void PrintZeroResult(string fileName)
        {
            Console.WriteLine($"\nВ файле {fileName} не удалось найти пробелов, или он весь состоит из пробелов");
        }

        /// <summary>
        /// Печать в консоль результата подсчёта пробелов в файле
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="spaceCount"></param>
        public static void PrintResult(string fileName,int spaceCount)
        {
            Console.WriteLine($"\nВ файле {fileName} удалось найти {spaceCount} пробелов");
        }

        /// <summary>
        /// Печать в консоль сообщения о завершении работы программы
        /// </summary>
        public static void PrintProgramEnd()
        {
            Console.WriteLine("\nПрограмма завершила свою работу");
        }

        /// <summary>
        /// Печать в консоль результата замера времени
        /// </summary>
        /// <param name="timeSpan"></param>
        /// <param name="testName"></param>
        public static void PrintStopWatch(TimeSpan timeSpan, string testName)
        {
            Console.WriteLine($"\nНа {testName} обработку ушло {timeSpan.ToString()}\n");
        }
    }
}
