using FileManagerTest.Infrastructure;
using FileManagerTest.Models;
using System;
using System.Text.RegularExpressions;

namespace FileManagerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Input path to start:  ");

            //FileManagerState.CurrentPath = Console.ReadLine();

            //Regex regularExp = new Regex(@"[A-Z]:\*");

            //while (!regularExp.IsMatch(FileManagerState.CurrentPath))
            //{
            //    Console.Write("Input path to start:  ");

            //    FileManagerState.CurrentPath = Console.ReadLine();
            //}

            //Console.Clear();

            FileManagerState.StartPath = @"C:\Test";
            FileManagerState.CurrentPath = FileManagerState.StartPath;

            var fileManager = new FileManager();

            fileManager.Start();

        }
    }
}
