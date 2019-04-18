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
            FileManagerState.StartPath = Console.ReadLine();

            while (!Directory.Exists(FileManagerState.StartPath))
            {
                Console.WriteLine("Directory does not exist!");
                Console.WriteLine();
                Console.Write("Input start directory path:  ");

                FileManagerState.StartPath = Console.ReadLine();
            }

            //FileManagerState.StartPath = @"C:\Test";
            FileManagerState.CurrentPath = FileManagerState.StartPath;

            var fileManager = new FileManager();

            fileManager.Start();
        }
    }
}
