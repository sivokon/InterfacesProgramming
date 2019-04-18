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

    }
}
