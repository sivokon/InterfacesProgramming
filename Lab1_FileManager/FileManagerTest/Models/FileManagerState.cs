using System.Collections.Generic;
using System.IO;

namespace FileManagerTest.Models
{
    public class FileManagerState
    {
        public string StartPath { get; set; }
        public string CurrentPath { get; set; }
        public string CurrentDirectoryName { get; set; }
        public List<FileSystemInfo> CurrentDirectoryFiles { get; set; }

        public string ClipboardFilePath { get; set; }
        public string ClipboardFileName { get; set; }

        public bool CopyFileStarted { get; set; }
        public bool MoveFileStarted { get; set; }
        public bool FileInfoMode { get; set; }

        public FileManagerState(string startPath)
        {
            StartPath = startPath;
            CurrentPath = startPath;

            CurrentDirectoryFiles = new List<FileSystemInfo>();
            CopyFileStarted = false;
            MoveFileStarted = false;
            FileInfoMode = false;
        }
    }
}
