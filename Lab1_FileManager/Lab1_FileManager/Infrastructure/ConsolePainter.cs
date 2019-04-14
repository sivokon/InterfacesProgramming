using Lab1_FileManager.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace Lab1_FileManager.Infrastructure
{
    public class ConsolePainter
    {
        private readonly CursorTracker _cursorTracker;

        public ConsolePainter(CursorTracker cursorTracker)
        {
            _cursorTracker = cursorTracker;
        }

        public void DrawLine(int x, int y, string content)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(x, y);
            Console.WriteLine(content);
        }

        public void DrawFolderFiles(List<FileSystemInfo> dirsAndFiles)
        {
            Console.SetCursorPosition(_cursorTracker.X, _cursorTracker.Y);
            foreach (var file in dirsAndFiles)
            {
                Console.WriteLine(file.Name);
            }
        }

        public void OnCursorMoved(object source, CursorEventArgs e)
        {
            Console.WriteLine(e.Ycoordinate);
        }

    }
}
