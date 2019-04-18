using FileManagerTest.Abstraction;
using FileManagerTest.Models;
using FileManagerTest.Services;
using System.IO;
using System.Linq;

namespace FileManagerTest.KeyHandlers
{
    public class RightArrowHandler : IKeyHandler
    {
        public void HandlePressedKey()
        {
            if (FileManagerState.FileInfoMode)
            {
                return;
            }

            if (FileManagerState.CurrentDirectoryFiles.Count == 0)
            {
                return;
            }

            var newPath = FileManagerState.CurrentPath + "\\" + 
                FileManagerState.CurrentDirectoryFiles[CursorState.Y - CursorState.MinY].Name;

            if (Directory.Exists(newPath))
            {
                FileManagerState.CurrentDirectoryName = 
                    FileManagerState.CurrentDirectoryFiles[CursorState.Y - CursorState.MinY].Name;

                FileManagerState.CurrentPath = newPath;

                var directory = new DirectoryInfo(newPath);
                FileManagerState.CurrentDirectoryFiles = directory.EnumerateFileSystemInfos().ToList();

                CursorState.ResetCursorState();
                CursorState.MaxY = FileManagerState.CurrentDirectoryFiles.Count;

                ConsolePaintService.DrawCurrentStateConsole();
            }

        }
    }
}
