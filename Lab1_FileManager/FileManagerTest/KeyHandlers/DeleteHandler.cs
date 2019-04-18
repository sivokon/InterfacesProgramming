using FileManagerTest.Abstraction;
using FileManagerTest.Models;
using FileManagerTest.Services;
using System.IO;
using System.Linq;

namespace FileManagerTest.KeyHandlers
{
    public class DeleteHandler : IKeyHandler
    {
        public void HandlePressedKey()
        {
            if (FileManagerState.FileInfoMode)
            {
                return;
            }

            string fileToDeleteName = 
                FileManagerState.CurrentDirectoryFiles[CursorState.Y - CursorState.MinY].Name;

            string fileToDeletePath = FileManagerState.CurrentPath + "\\" + fileToDeleteName;

            File.Delete(fileToDeletePath);

            var directory = new DirectoryInfo(FileManagerState.CurrentPath);
            FileManagerState.CurrentDirectoryFiles = directory.EnumerateFileSystemInfos().ToList();

            CursorState.ResetCursorState();
            CursorState.MaxY = FileManagerState.CurrentDirectoryFiles.Count;

            ConsolePaintService.DrawCurrentStateConsole();
        }
    }
}
