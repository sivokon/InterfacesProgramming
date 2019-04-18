using FileManagerTest.Models;
using System;

namespace FileManagerTest.Services
{
    public static class ConsolePaintService
    {
        public static void DrawLine(int cursorX, int cursorY, string lineContent)
        {
            Console.SetCursorPosition(cursorX, cursorY);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(cursorX, cursorY);
            Console.WriteLine(lineContent);
            Console.SetCursorPosition(cursorX, cursorY);
        }

        public static void DrawCurrentStateConsole()
        {
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
