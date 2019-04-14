using Lab1_FileManager.Infrastructure;
using System;

namespace Lab1_FileManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Specify folder to start your work:");
            ////var pathToStart = Console.ReadLine();
            var pathToStart = @"D:\Test";

            //Console.Clear();
            //Console.WriteLine($"Current directory: {pathToStart}");

            var filesRepository = new FilesRepository();
            var dirsAndFiles = filesRepository.GetFolderFiles(pathToStart);

            var cursorTracker = new CursorTracker();
            var consolePainter = new ConsolePainter(cursorTracker);
            cursorTracker.CursorMoved += consolePainter.OnCursorMoved;
            consolePainter.DrawFolderFiles(dirsAndFiles);

            do
            {
                var consoleKeyInfo = Console.ReadKey(true);
                cursorTracker.TrackCursor(consoleKeyInfo);
                //Console.WriteLine(cursorTracker.Y);
            }
            while (true);

            Console.ReadLine();
        }
    }
}
