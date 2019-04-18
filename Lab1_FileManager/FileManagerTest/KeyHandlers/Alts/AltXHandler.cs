using FileManagerTest.Abstraction;
using FileManagerTest.Models;
using System;

namespace FileManagerTest.KeyHandlers
{
    public class AltXHandler : IKeyHandler
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

            FileManagerState.CopyFileStarted = false;
            FileManagerState.MoveFileStarted = true;
        }
    }
}
