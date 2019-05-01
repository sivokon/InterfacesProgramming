using FileManagerTest.Abstraction;
using FileManagerTest.Models;
using FileManagerTest.Services;
using System.IO;
using System.Linq;

namespace FileManagerTest.KeyHandlers
{
    public class DeleteHandler : IKeyHandler
    {
        public void HandlePressedKey(FileManagerState fileManagerState)
        {
            if (fileManagerState.FileInfoMode)
            {
                return;
            }

            string fileToDeleteName =
                fileManagerState.CurrentDirectoryFiles[CursorState.Y - CursorState.MinY].Name;

            string fileToDeletePath = fileManagerState.CurrentPath + "\\" + fileToDeleteName;

            File.Delete(fileToDeletePath);

            var directory = new DirectoryInfo(fileManagerState.CurrentPath);
            fileManagerState.CurrentDirectoryFiles = directory.EnumerateFileSystemInfos().ToList();

            CursorState.ResetCursorState();
            CursorState.MaxY = fileManagerState.CurrentDirectoryFiles.Count;

            ConsolePaintService.DrawCurrentStateConsole(fileManagerState);
        }
    }
}
