using App.Abstractions;

namespace App.Services
{
    internal class FolderService : IFolderService
    {
        public void CreateFolder(string path)
        {
            try
            {
                if (string.IsNullOrEmpty(path))
                {
                    throw new ArgumentNullException(nameof(path), "The folder path can't be null or empty.");
                }

                Directory.CreateDirectory(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while creating folder: {ex.Message}");
            }
        }

        public void DeleteFolder(string path, bool recursive = false)
        {
            try
            {
                if (string.IsNullOrEmpty(path))
                {
                    throw new ArgumentNullException(nameof(path), "The folder path can't be null or empty.");
                }

                if (!Directory.Exists(path))
                {
                    throw new DirectoryNotFoundException($"The folder {path} wasn't found.");
                }

                Directory.Delete(path, recursive);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while deleting folder: {ex.Message}");
            }
        }

        public void RenameFolder(string oldPath, string newPath)
        {
            try
            {
                if (string.IsNullOrEmpty(oldPath))
                {
                    throw new ArgumentNullException(nameof(oldPath), "the old path can't be null or empty.");
                }

                if (string.IsNullOrEmpty(newPath))
                {
                    throw new ArgumentNullException(nameof(newPath), "the new path can't be null or empty.");
                }

                if (!Directory.Exists(oldPath))
                {
                    throw new DirectoryNotFoundException($"the folder {oldPath} wasn't found.");
                }

                Directory.Move(oldPath, newPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while renaming folder: {ex.Message}");
            }
        }

        public void MoveFolder(string sourcePath, string destinationPath)
        {
            RenameFolder(sourcePath, destinationPath);
        }

    }
}
