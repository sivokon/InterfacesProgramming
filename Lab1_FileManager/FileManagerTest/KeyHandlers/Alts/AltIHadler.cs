using FileManagerTest.Abstraction;
using FileManagerTest.Models;
using System;
using System.IO;

namespace FileManagerTest.KeyHandlers
{
    public class AltIHandler : IKeyHandler
    {
        public void HandlePressedKey(FileManagerState fileManagerState)
        {
            var fileSystemInfo =
                fileManagerState.CurrentDirectoryFiles[CursorState.Y - CursorState.MinY] as FileInfo;

            if (fileSystemInfo != null)
            {
                CursorState.ResetCursorState();
                CursorState.MaxY = CursorState.MinY;

                Console.Clear();

                Console.WriteLine("-------------------- MODERN FILE MANAGER --------------------");
                Console.WriteLine();
                Console.WriteLine("(Press <-- to return)");
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine($"Parent directory:     {fileSystemInfo.Directory}");
                Console.WriteLine();
                Console.WriteLine($"Name:                 {fileSystemInfo.Name}");
                Console.WriteLine($"Extension:            {fileSystemInfo.Extension}");
                Console.WriteLine($"Size:                 {fileSystemInfo.Length}");
                Console.WriteLine();
                Console.WriteLine($"Creation time:        {fileSystemInfo.CreationTime}");
                Console.WriteLine($"Creation time (UTC):  {fileSystemInfo.CreationTimeUtc}");
                Console.WriteLine();
                Console.WriteLine($"Last changed:         {fileSystemInfo.LastWriteTime}");
                Console.WriteLine($"Last changed (UTC):   {fileSystemInfo.LastWriteTimeUtc}");
                Console.WriteLine();
                Console.WriteLine($"Last accessed:        {fileSystemInfo.LastAccessTime}");
                Console.WriteLine($"Last accessed (UTC):  {fileSystemInfo.LastAccessTimeUtc}");

                Console.CursorVisible = false;

                fileManagerState.FileInfoMode = true;
            }
        }
    }
}
