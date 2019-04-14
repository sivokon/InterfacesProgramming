using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Lab1_FileManager.Infrastructure
{
    public class FilesRepository
    {
        public FilesRepository()
        {

        }

        public List<FileSystemInfo> GetFolderFiles(string folderPath)
        {
            var directory = new DirectoryInfo(folderPath);
            var directoriesAndFiles = directory.EnumerateFileSystemInfos();

            return directoriesAndFiles.ToList();
        }



    }
}
