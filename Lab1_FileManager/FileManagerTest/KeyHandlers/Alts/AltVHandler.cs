using FileManagerTest.Abstraction;
using FileManagerTest.Models;
using FileManagerTest.Services;
using System.IO;
using System.Linq;

namespace FileManagerTest.KeyHandlers
{
    public class AltVHandler : IKeyHandler
    {
        public void HandlePressedKey(FileManagerState fileManagerState)
        {
            if (fileManagerState.FileInfoMode)
            {
                return;
            }

            if (!string.IsNullOrEmpty(fileManagerState.ClipboardFilePath) && 
                !string.IsNullOrEmpty(fileManagerState.ClipboardFileName) &&
                (fileManagerState.CopyFileStarted || fileManagerState.MoveFileStarted))
            {
                if (fileManagerState.CopyFileStarted)
                {
                    File.Copy(
                        $"{fileManagerState.ClipboardFilePath}\\{fileManagerState.ClipboardFileName}",
                        $"{fileManagerState.CurrentPath}\\{fileManagerState.ClipboardFileName}");
                }
                if (fileManagerState.MoveFileStarted)
                {
                    File.Move(
                        $"{fileManagerState.ClipboardFilePath}\\{fileManagerState.ClipboardFileName}",
                        $"{fileManagerState.CurrentPath}\\{fileManagerState.ClipboardFileName}");
                }

                var directory = new DirectoryInfo(fileManagerState.CurrentPath);
                fileManagerState.CurrentDirectoryFiles = directory.EnumerateFileSystemInfos().ToList();

                CursorState.ResetCursorState();
                CursorState.MaxY = fileManagerState.CurrentDirectoryFiles.Count;

                ConsolePaintService.DrawCurrentStateConsole(fileManagerState);

                fileManagerState.CopyFileStarted = false;
                fileManagerState.MoveFileStarted = false;
            }
        }
    }
}
