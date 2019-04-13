using System;
using System.Collections.Generic;

namespace Lab1_FileManager.Infrasctruture
{
    public class ConsolePainter
    {
        public ConsolePainter()
        {

        }

        public void DrawLine(int x, int y, string content)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(x, y);
            Console.WriteLine(content);
        }

        public void DrawFolderFiles(int x, int y, List<string> folderFiles)
        {
            foreach (var file in folderFiles)
            {
                Console.WriteLine(file);
            }
        }
    }
}
