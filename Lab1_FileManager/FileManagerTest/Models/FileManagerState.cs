using System.Collections.Generic;
using System.IO;

namespace FileManagerTest.Models
{
    public static class FileManagerState
    {
        public static string StartPath { get; set; }
        public static string CurrentPath { get; set; }
        public static string CurrentDirectoryName { get; set; }
        public static List<FileSystemInfo> CurrentDirectoryFiles { get; set; }

        public static string ClipboardFilePath { get; set; }
        public static string ClipboardFileName { get; set; }

        public static bool CopyFileStarted { get; set; } = false;
        public static bool MoveFileStarted { get; set; } = false;
        public static bool FileInfoMode { get; set; } = false;

    }
}
