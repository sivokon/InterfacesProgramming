﻿using FileManagerTest.Abstraction;
using FileManagerTest.Models;
using FileManagerTest.Services;

namespace FileManagerTest.KeyHandlers
{
    public class UpArrowHandler : IKeyHandler
    {
        public void HandlePressedKey()
        {
            if (FileManagerState.FileInfoMode)
            {
                return;
            }

            if (CursorState.Y > CursorState.MinY)
            {
                ConsolePaintService.DrawLine(
                    CursorState.X,
                    CursorState.Y,
                    FileManagerState.CurrentDirectoryFiles[CursorState.Y - CursorState.MinY].Name);

                CursorState.Y--;

                ConsolePaintService.DrawLine(
                    CursorState.X,
                    CursorState.Y,
                    $"> {FileManagerState.CurrentDirectoryFiles[CursorState.Y - CursorState.MinY].Name}");
            }
        }
    }
}
