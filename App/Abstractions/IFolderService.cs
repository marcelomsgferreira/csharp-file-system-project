using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Abstractions
{
    internal interface IFolderService
    {
        public void CreateFolder(string path);
        public void DeleteFolder(string path, bool recursive = false);
        public void RenameFolder(string oldPath, string newPath);
        public void MoveFolder(string sourcePath, string destinationPath);
    }
}
