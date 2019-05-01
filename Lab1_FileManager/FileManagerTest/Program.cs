using FileManagerTest.Infrastructure;
using FileManagerTest.Models;
using System;
using System.IO;

namespace FileManagerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input start directory path:  ");
            var startPath = Console.ReadLine();

            while (!Directory.Exists(startPath))
            {
                Console.WriteLine("Directory does not exist!");
                Console.WriteLine();
                Console.Write("Input start directory path:  ");

                startPath = Console.ReadLine();
            }

            var fileManagerState = new FileManagerState(@"C:\Test");
            //var fileManagerState = new FileManagerState(startPath);
            var keyDefiner = new KeyDefiner();
            var fileManager = new FileManager(fileManagerState, keyDefiner);

            fileManager.Start();
        }
    }
}
