using FileManagerTest.Abstraction;
using FileManagerTest.Models;
using FileManagerTest.Services;
using System.IO;
using System.Linq;

namespace FileManagerTest.KeyHandlers
{
    public class RightArrowHandler : IKeyHandler
    {
        public void HandlePressedKey(FileManagerState fileManagerState)
        {
            if (fileManagerState.FileInfoMode)
            {
                return;
            }

            if (fileManagerState.CurrentDirectoryFiles.Count == 0)
            {
                return;
            }

            var newPath = fileManagerState.CurrentPath + "\\" +
                fileManagerState.CurrentDirectoryFiles[CursorState.Y - CursorState.MinY].Name;

            if (Directory.Exists(newPath))
            {
                fileManagerState.CurrentDirectoryName =
                    fileManagerState.CurrentDirectoryFiles[CursorState.Y - CursorState.MinY].Name;

                fileManagerState.CurrentPath = newPath;

                var directory = new DirectoryInfo(newPath);
                fileManagerState.CurrentDirectoryFiles = directory.EnumerateFileSystemInfos().ToList();

                CursorState.ResetCursorState();
                CursorState.MaxY = fileManagerState.CurrentDirectoryFiles.Count;

                ConsolePaintService.DrawCurrentStateConsole();
            }

        }
    }
}
