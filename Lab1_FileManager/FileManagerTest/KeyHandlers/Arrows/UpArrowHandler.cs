using FileManagerTest.Abstraction;
using FileManagerTest.Models;
using FileManagerTest.Services;

namespace FileManagerTest.KeyHandlers
{
    public class UpArrowHandler : IKeyHandler
    {
        public void HandlePressedKey(FileManagerState fileManagerState)
        {
            if (fileManagerState.FileInfoMode)
            {
                return;
            }

            if (CursorState.Y > CursorState.MinY)
            {
                ConsolePaintService.DrawLine(
                    CursorState.X,
                    CursorState.Y,
                    fileManagerState.CurrentDirectoryFiles[CursorState.Y - CursorState.MinY].Name);

                CursorState.Y--;

                ConsolePaintService.DrawLine(
                    CursorState.X,
                    CursorState.Y,
                    $"> {fileManagerState.CurrentDirectoryFiles[CursorState.Y - CursorState.MinY].Name}");
            }
        }
    }
}
