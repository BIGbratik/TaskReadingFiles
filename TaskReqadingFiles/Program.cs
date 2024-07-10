using System.Diagnostics;
using TaskReadingFiles;

ConsoleManager.PrintHello();

var dir = ConsoleManager.GetDirrectoryPath();

var isDirValid = DirectoryManager.ValidateDirectory(dir);

if (isDirValid == true )
{
    var stopWatch = new Stopwatch();

    stopWatch.Start();
    var files = DirectoryManager.GetAllFiles(dir);

    var taskList = new Task[files.Length];

    for (int i =0;  i < taskList.Length; i++)
    {
        var file = files[i];
        var task = new Task(() => FileManager.CountSpacesInFile(file));
        taskList[i] = task;
        taskList[i].Start();
    }

    Task.WaitAll(taskList);

    stopWatch.Stop();
    ConsoleManager.PrintStopWatch(stopWatch.Elapsed, "параллельную");

    stopWatch.Restart();
    foreach (var file in files)
    {
        FileManager.CountSpacesInFile(file);
    }

    stopWatch.Stop();
    ConsoleManager.PrintStopWatch(stopWatch.Elapsed, "последовательную");
}