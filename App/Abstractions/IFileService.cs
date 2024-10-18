using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Abstractions
{
    internal interface IFileService
    {
        public void CopyFile(string sourcePath, string destinationPath, bool overwrite = false);
        public void DeleteFile(string filePath);
        public void CreateFile(string filePath, bool overwrite = false);
        public void WriteFile(string filePath, string content, bool append = false);
        public void MoveFile(string sourcePath, string destinationPath);
        public void ReadFile(string filePath);
        public void RenameFile(string oldPath, string newPath);
    }
}
