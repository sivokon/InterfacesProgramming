using FileManagerTest.Abstraction;
using FileManagerTest.Models;
using System;
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

                Console.Clear();

                Console.WriteLine("-------------------- MODERN FILE MANAGER --------------------");
                Console.WriteLine();
                Console.Write("ALT+C(Copy)   ALT+X(Cut)   ALT+V(Paste)   ALT+I(File info)   DELETE \n");
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine($"Current directory: {FileManagerState.CurrentPath}");
                Console.WriteLine();

                for (int i = 0; i < FileManagerState.CurrentDirectoryFiles.Count; i++)
                {
                    if (i == 0)
                    {
                        Console.WriteLine($"> {FileManagerState.CurrentDirectoryFiles[i]}");
                    }
                    else
                    {
                        Console.WriteLine(FileManagerState.CurrentDirectoryFiles[i]);
                    }
                }

                Console.SetCursorPosition(CursorState.X, CursorState.Y);

                FileManagerState.CopyFileStarted = false;
                FileManagerState.MoveFileStarted = false;
            }
        }
    }
}
