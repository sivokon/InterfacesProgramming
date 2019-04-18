using FileManagerTest.Abstraction;
using FileManagerTest.Models;
using System;
using System.IO;
using System.Linq;

namespace FileManagerTest.KeyHandlers
{
    public class DeleteHandler : IKeyHandler
    {
        public void HandlePressedKey()
        {
            if (FileManagerState.FileInfoMode)
            {
                return;
            }

            string fileToDeleteName = 
                FileManagerState.CurrentDirectoryFiles[CursorState.Y - CursorState.MinY].Name;

            string fileToDeletePath = FileManagerState.CurrentPath + "\\" + fileToDeleteName;

            File.Delete(fileToDeletePath);

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
        }
    }
}
