using FileManagerTest.Abstraction;
using FileManagerTest.Models;

namespace FileManagerTest.KeyHandlers
{
    public class AltCHandler : IKeyHandler
    {       
        public void HandlePressedKey(FileManagerState fileManagerState)
        {
            if (fileManagerState.FileInfoMode)
            {
                return;
            }

            fileManagerState.ClipboardFilePath = fileManagerState.CurrentPath;

            fileManagerState.ClipboardFileName =
                fileManagerState.CurrentDirectoryFiles[CursorState.Y - CursorState.MinY].Name;

            fileManagerState.CopyFileStarted = true;
            fileManagerState.MoveFileStarted = false;
        }
    }
}
