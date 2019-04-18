using FileManagerTest.Abstraction;
using FileManagerTest.Models;
using FileManagerTest.Services;
using System.IO;
using System.Linq;

namespace FileManagerTest.KeyHandlers
{
    public class AltVHandler : IKeyHandler
    {
        public void HandlePressedKey()
        {
            if (FileManagerState.FileInfoMode)
            {
                return;
            }

            if (!string.IsNullOrEmpty(FileManagerState.ClipboardFilePath) && 
                !string.IsNullOrEmpty(FileManagerState.ClipboardFileName) &&
                (FileManagerState.CopyFileStarted || FileManagerState.MoveFileStarted))
            {
                if (FileManagerState.CopyFileStarted)
                {
                    File.Copy(
                        $"{FileManagerState.ClipboardFilePath}\\{FileManagerState.ClipboardFileName}",
                        $"{FileManagerState.CurrentPath}\\{FileManagerState.ClipboardFileName}");
                }
                if (FileManagerState.MoveFileStarted)
                {
                    File.Move(
                        $"{FileManagerState.ClipboardFilePath}\\{FileManagerState.ClipboardFileName}",
                        $"{FileManagerState.CurrentPath}\\{FileManagerState.ClipboardFileName}");
                }

                var directory = new DirectoryInfo(FileManagerState.CurrentPath);
                FileManagerState.CurrentDirectoryFiles = directory.EnumerateFileSystemInfos().ToList();

                CursorState.ResetCursorState();
                CursorState.MaxY = FileManagerState.CurrentDirectoryFiles.Count;

                ConsolePaintService.DrawCurrentStateConsole();

                FileManagerState.CopyFileStarted = false;
                FileManagerState.MoveFileStarted = false;
            }
        }
    }
}
