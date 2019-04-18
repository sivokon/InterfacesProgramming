using FileManagerTest.Models;
using System;
using System.IO;
using System.Linq;

namespace FileManagerTest.Infrastructure
{
    public class FileManager
    {
        public void Start()
        {
            Console.WriteLine("-------------------- MODERN FILE MANAGER --------------------");
            Console.WriteLine();
            Console.Write("ALT+C(Copy)   ALT+X(Cut)   ALT+V(Paste)   ALT+I(File info)   DELETE \n");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"Current directory: {FileManagerState.CurrentPath}");
            Console.WriteLine();

            var directory = new DirectoryInfo(FileManagerState.CurrentPath);
            FileManagerState.CurrentDirectoryFiles = directory.EnumerateFileSystemInfos().ToList();

            CursorState.ResetCursorState();
            CursorState.MaxY = FileManagerState.CurrentDirectoryFiles.Count;

            for (int i = 0; i < FileManagerState.CurrentDirectoryFiles.Count; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine($"> {FileManagerState.CurrentDirectoryFiles[i]}");
                }
                else
                {
                    Console.WriteLine(FileManagerState.CurrentDirectoryFiles[i]);
                }
            }
            Console.SetCursorPosition(CursorState.X, CursorState.Y);

            var keyDefiner = new KeyDefiner();
            do
            {
                var consoleKeyInfo = Console.ReadKey(true);

                var keyHandler = keyDefiner.DefinePressedKey(consoleKeyInfo);

                keyHandler.HandlePressedKey();
            }
            while (true);
        }

    }
}
