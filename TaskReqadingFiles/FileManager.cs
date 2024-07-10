namespace TaskReadingFiles
{
    public static class FileManager
    {
        /// <summary>
        /// Подсчёт кол-ва пробелов в текстовом файле
        /// </summary>
        /// <param name="filePath"></param>
        public static void CountSpacesInFile(string filePath)
        {
            var fileText = File.ReadAllText(filePath);
            var fileInfo = new FileInfo(filePath);

            if (string.IsNullOrWhiteSpace(fileText) || string.IsNullOrEmpty(fileText))
            {
                ConsoleManager.PrintZeroResult(fileInfo.Name);
            }
            else
            {
                // При подсчёте кол-ва можно было бы использовать метод определения пробелов Char.IsWhiteSpace,
                // но он счетает все КАТЕГОРИИ пробелов (т.е. и переносы строк тоже)
                var spaceCount = fileText.Count(t => t == ' ');
                ConsoleManager.PrintResult(fileInfo.Name, spaceCount);
            }
        }
    }
}
