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
        public void HandlePressedKey(FileManagerState fileManagerState)
        {
            if ((fileManagerState.CurrentPath == fileManagerState.StartPath) && !fileManagerState.FileInfoMode)
            {
                return;
            }

            if (fileManagerState.CurrentDirectoryName != null && !fileManagerState.FileInfoMode)
            {
                var newPath = fileManagerState.CurrentPath.Replace($"\\{fileManagerState.CurrentDirectoryName}", "");

                if (Directory.Exists(newPath))
                {
                    fileManagerState.CurrentDirectoryName = newPath.Substring(newPath.LastIndexOf("\\") + 1);

                    fileManagerState.CurrentPath = newPath;

                    var directory = new DirectoryInfo(newPath);
                    fileManagerState.CurrentDirectoryFiles = directory.EnumerateFileSystemInfos().ToList();
                }
            }

            CursorState.ResetCursorState();
            CursorState.MaxY = fileManagerState.CurrentDirectoryFiles.Count;

            ConsolePaintService.DrawCurrentStateConsole(fileManagerState);

            Console.CursorVisible = true;
            fileManagerState.FileInfoMode = false;
        }
    }
}
