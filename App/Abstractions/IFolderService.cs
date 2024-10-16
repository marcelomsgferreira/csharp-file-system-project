using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Abstractions
{
    internal interface IFolderService
    {
        public bool CreateFolder(string path);
        public bool DeleteFolder(string path, bool recursive = false);
        public bool RenameFolder(string oldPath, string newPath);
        public bool MoveFolder(string sourcePath, string destinationPath);
        public void CopyFolder(string source, string dest);
    }
}
