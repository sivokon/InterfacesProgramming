using FileManagerTest.Models;
using FileManagerTest.Services;
using System;
using System.IO;
using System.Linq;

namespace FileManagerTest.Infrastructure
{
    public class FileManager
    {
        public void Start()
        {
            var directory = new DirectoryInfo(FileManagerState.CurrentPath);
            FileManagerState.CurrentDirectoryFiles = directory.EnumerateFileSystemInfos().ToList();

            CursorState.ResetCursorState();
            CursorState.MaxY = FileManagerState.CurrentDirectoryFiles.Count;

            ConsolePaintService.DrawCurrentStateConsole();

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
