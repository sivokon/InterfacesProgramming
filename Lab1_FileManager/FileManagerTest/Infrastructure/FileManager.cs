using FileManagerTest.Models;
using FileManagerTest.Services;
using System;
using System.IO;
using System.Linq;

namespace FileManagerTest.Infrastructure
{
    public class FileManager
    {
        private FileManagerState _fileManagerState;
        private KeyDefiner _keyDefiner;

        public FileManager(FileManagerState fileManagerState, KeyDefiner keyDefiner)
        {
            _fileManagerState = fileManagerState;
            _keyDefiner = keyDefiner;
        }

        public void Start()
        {
            var directory = new DirectoryInfo(_fileManagerState.CurrentPath);
            _fileManagerState.CurrentDirectoryFiles = directory.EnumerateFileSystemInfos().ToList();

            CursorState.ResetCursorState();
            CursorState.MaxY = _fileManagerState.CurrentDirectoryFiles.Count;

            ConsolePaintService.DrawCurrentStateConsole(_fileManagerState);

            do
            {
                var consoleKeyInfo = Console.ReadKey(true);

                var keyHandler = _keyDefiner.DefinePressedKey(consoleKeyInfo);

                keyHandler.HandlePressedKey(_fileManagerState);
            }
            while (true);
        }

    }
}
