using FileManagerTest.Abstraction;
using FileManagerTest.Models;
using System;

namespace FileManagerTest.KeyHandlers
{
    public class AltXHandler : IKeyHandler
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

            fileManagerState.CopyFileStarted = false;
            fileManagerState.MoveFileStarted = true;
        }
    }
}
