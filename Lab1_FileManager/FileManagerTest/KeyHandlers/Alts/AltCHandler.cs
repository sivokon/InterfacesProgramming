using FileManagerTest.Abstraction;
using FileManagerTest.Models;

namespace FileManagerTest.KeyHandlers
{
    public class AltCHandler : IKeyHandler
    {       
        public void HandlePressedKey()
        {
            if (FileManagerState.FileInfoMode)
            {
                return;
            }

            FileManagerState.ClipboardFilePath = FileManagerState.CurrentPath;

            FileManagerState.ClipboardFileName = 
                FileManagerState.CurrentDirectoryFiles[CursorState.Y - CursorState.MinY].Name;

            FileManagerState.CopyFileStarted = true;
            FileManagerState.MoveFileStarted = false;
        }
    }
}
