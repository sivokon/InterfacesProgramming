using FileManagerTest.Abstraction;
using FileManagerTest.Models;
using FileManagerTest.Services;
using System;
using System.IO;
using System.Linq;

namespace FileManagerTest.KeyHandlers
{
    public class LeftArrowHandler : IKeyHandler
    {
        public void HandlePressedKey()
        {
            if ((FileManagerState.CurrentPath == FileManagerState.StartPath) && !FileManagerState.FileInfoMode)
            {
                return;
            }

            if (FileManagerState.CurrentDirectoryName != null && !FileManagerState.FileInfoMode)
            {
                var newPath = FileManagerState.CurrentPath.Replace($"\\{FileManagerState.CurrentDirectoryName}", "");

                if (Directory.Exists(newPath))
                {
                    FileManagerState.CurrentDirectoryName = newPath.Substring(newPath.LastIndexOf("\\") + 1);

                    FileManagerState.CurrentPath = newPath;

                    var directory = new DirectoryInfo(newPath);
                    FileManagerState.CurrentDirectoryFiles = directory.EnumerateFileSystemInfos().ToList();
                }
            }

            CursorState.ResetCursorState();
            CursorState.MaxY = FileManagerState.CurrentDirectoryFiles.Count;

            ConsolePaintService.DrawCurrentStateConsole();

            Console.CursorVisible = true;
            FileManagerState.FileInfoMode = false;
        }
    }
}
