namespace TaskReadingFiles
{
    public static class DirectoryManager
    {
        private const string _fileExtPattern = "*.txt";

        /// <summary>
        /// Валидация директории на рпедмет её существования и наличия в ней файлов  сраширение .txt
        /// </summary>
        /// <param name="dirPath">Полный путь до директории</param>
        /// <returns></returns>
        public static bool ValidateDirectory(string dirPath)
        {
            if (Directory.Exists(dirPath))
            {
                if (Directory.GetFiles(dirPath,_fileExtPattern).Any())
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Получение всех файлов с расширением .txt из указанной директории
        /// </summary>
        /// <param name="dirPath">Полный путь до директории</param>
        /// <returns></returns>
        public static string[] GetAllFiles(string dirPath)
        {
            return Directory.GetFiles(dirPath, _fileExtPattern);
        }
    }
}
