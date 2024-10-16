using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Abstractions
{
    internal interface IFileService
    {
        public bool CopyFile(string sourcePath, string destinationPath, bool overwrite = false);
        public bool DeleteFile(string filePath);
        public bool CreateFile(string filePath, bool overwrite = false);
        public bool WriteFile(string filePath, string content, bool append = false);
        public bool MoveFile(string sourcePath, string destinationPath);
        public string? ReadFile(string filePath);
        public bool RenameFile(string oldPath, string newPath);
    }
}
