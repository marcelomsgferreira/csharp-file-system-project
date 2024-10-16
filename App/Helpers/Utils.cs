using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Helpers
{
    internal static class Utils
    {
        public static int MainMenu()
        {
            Console.WriteLine("Welcome to our File Management System:");
            Console.WriteLine("Select one of the options below:");
            Console.WriteLine("1. Manage Files");
            Console.WriteLine("2. Manage Folders");
            Console.WriteLine("0. Exit");
            return int.Parse(Console.ReadLine());
        }

        public static int FileMenu()
        {
            Console.WriteLine("Well choosen option!");
            Console.WriteLine("Now select which type of operation you want to do:");
            Console.WriteLine("1. Create File");
            Console.WriteLine("2. Read File");
            Console.WriteLine("3. Write File");
            Console.WriteLine("4. Delete File");
            Console.WriteLine("5. Rename File");
            Console.WriteLine("6. Copy File");
            Console.WriteLine("7. Move File");
            Console.WriteLine("0. Exit");
            return int.Parse(Console.ReadLine());
        }

        public static int FolderMenu()
        {
            Console.WriteLine("Well choosen option!");
            Console.WriteLine("Now select which type of operation you want to do:");
            Console.WriteLine("1. Create Folder");
            Console.WriteLine("2. Delete Folder");
            Console.WriteLine("3. Rename Folder");
            Console.WriteLine("4. Move Folder");
            Console.WriteLine("0. Exit");
            return int.Parse(Console.ReadLine());
        }

        public static string? InsertFilePath()
        {
            Console.WriteLine("Type the File Path: ");
            return Console.ReadLine();
        }
        public static string? InsertSourceFileName()
        {
            Console.WriteLine("Type the Source File Name with full path: ");
            return Console.ReadLine();
        }
        public static string? InsertDestFileName()
        {
            Console.WriteLine("Type the Dest File Name with full path: ");
            return Console.ReadLine();
        }
    }
}
