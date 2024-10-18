using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Helpers.Validators
{
    internal static class PathValidator
    {
        public static bool IsValidPath(string fullPath)
        {
            try
            {
                var fileInfo = new FileInfo(fullPath);
                fileInfo.Refresh();

                if (!System.Text.RegularExpressions.Regex.IsMatch(fullPath, @"^(([a-zA-Z]:\\)|\\)(\\{1,2})[^\/:*?""<>|\s]+((\\{1,2}[^\/:*?""<>|\s]+)+)?(\.[^\/:*?""<>|\s]+)?$"))
                {
                    Console.WriteLine("The path doesn't corresponds to the windows format.");
                    return false;
                }

                if (!fileInfo.Exists)
                {
                    Console.WriteLine($"The file: ${fullPath} doesn't exists.");
                    return false; 
                }
                if (fileInfo.IsReadOnly) 
                {
                    Console.WriteLine("The file exists but is just enable for reading.");
                    return false; 
                }

                if (!IsValidExtension(fileInfo.Extension)) 
                {
                    Console.WriteLine("The file extension isn't valid.");
                    return false;
                }
                if (!IsValidSize(fileInfo.Length)) 
                {
                    Console.WriteLine("The path size isn't valid.");
                    return false;
                }
                if (!IsValidDirectory(fileInfo.DirectoryName)) 
                {
                    Console.WriteLine("The directory isn't valid.");
                    return false;
                }
                if (!IsValidAttributes(fileInfo.Attributes)) 
                {
                    Console.WriteLine("The file attributes aren't valid.");
                    return false;
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool IsValidNewPath(string fullPath)
        {
            try
            {
                var fileInfo = new FileInfo(fullPath);
                fileInfo.Refresh();

                if (!System.Text.RegularExpressions.Regex.IsMatch(fullPath, @"^(([a-zA-Z]:\\)|\\)(\\{1,2})[^\/:*?""<>|\s]+((\\{1,2}[^\/:*?""<>|\s]+)+)?(\.[^\/:*?""<>|\s]+)?$"))
                {
                    Console.WriteLine("The path doesn't corresponds to the windows format.");
                    return false;
                }

                if (!IsValidExtension(fileInfo.Extension))
                {
                    Console.WriteLine("The file extension isn't valid.");
                    return false;
                }
                if (!IsValidSize(fileInfo.Length))
                {
                    Console.WriteLine("The path size isn't valid.");
                    return false;
                }
                if (!IsValidDirectory(fileInfo.DirectoryName))
                {
                    Console.WriteLine("The directory isn't valid.");
                    return false;
                }
                if (!IsValidAttributes(fileInfo.Attributes))
                {
                    Console.WriteLine("The file attributes aren't valid.");
                    return false;
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private static bool IsValidExtension(string extension)
        {
            var allowedExtensions = new[] { ".txt", ".csv", ".xlsx" };
            return allowedExtensions.Contains(extension, StringComparer.OrdinalIgnoreCase);
        }

        private static bool IsValidSize(long size)
        {
            return size <= 1024 * 1024 * 10;
        }

        private static bool IsValidDirectory(string directory)
        {
            return Directory.Exists(directory);
        }

        private static bool IsValidAttributes(FileAttributes attributes)
        {
            return (attributes & (FileAttributes.Hidden | FileAttributes.System)) == 0;
        }
    }
}
