using App.Abstractions;
using App.Helpers.Validators;
using System.Text;

namespace App.Services
{
    internal class FileService : IFileService
    {
        public void CopyFile(string sourcePath, string destinationPath, bool overwrite = false)
        {
            try
            {
                if (string.IsNullOrEmpty(sourcePath))
                {
                    throw new ArgumentNullException(nameof(sourcePath), "The origin path can't be null or empty.");
                }

                if (string.IsNullOrEmpty(destinationPath))
                {
                    throw new ArgumentNullException(nameof(destinationPath), "The destination path can't be null or empty.");
                }

                if (PathValidator.IsValidPath(sourcePath) == false) return;
                if (PathValidator.IsValidNewPath(destinationPath) == false) return;

                File.Copy(sourcePath, destinationPath, overwrite);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while copying File: {ex.Message}");
            }
        }
        public void DeleteFile(string filePath)
        {
            try
            {
                if (string.IsNullOrEmpty(filePath))
                {
                    throw new ArgumentNullException(nameof(filePath), "The file path can't be null or empty.");
                }

                if (PathValidator.IsValidPath(filePath) == false) return;

                File.Delete(filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fail while deleting the file: {ex.Message}");
            }
        }
        public void CreateFile(string filePath, bool overwrite = false)
        {
            try
            {
                // Validações
                if (string.IsNullOrEmpty(filePath))
                {
                    throw new ArgumentNullException(nameof(filePath), "The file path can't be null or empty.");
                }

                if (File.Exists(filePath) && !overwrite)
                {
                    throw new IOException($"The file {filePath} already exists. specify overwrite = true to overwrite file.");
                }

                if (PathValidator.IsValidNewPath(filePath) == false) return;

                File.Create(filePath).Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while creating file: {ex.Message}");
            }
        }
        public void WriteFile(string filePath, string content, bool append = false)
        {
            try
            {
                if (string.IsNullOrEmpty(filePath))
                {
                    throw new ArgumentNullException(nameof(filePath), "The file path can't be null or empty.");
                }
                
                if(PathValidator.IsValidPath(filePath) == false) return;

                File.WriteAllText(filePath, content, append ? Encoding.UTF8 : Encoding.Default);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while loading file: {ex.Message}");
            }
        }
        public void MoveFile(string sourcePath, string destinationPath)
        {
            try
            {
                if (string.IsNullOrEmpty(sourcePath))
                {
                    throw new ArgumentNullException(nameof(sourcePath), "The origin path can't be null or empty.");
                }

                if (string.IsNullOrEmpty(destinationPath))
                {
                    throw new ArgumentNullException(nameof(destinationPath), "The destination path can't be null or empty.");
                }

                if(PathValidator.IsValidPath(sourcePath) == false) return; 
                if(PathValidator.IsValidNewPath(destinationPath) == false) return;

                File.Move(sourcePath, destinationPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while moving file: {ex.Message}");
            }
        }
        public void ReadFile(string filePath)
        {
            try
            {
                if (string.IsNullOrEmpty(filePath))
                {
                    throw new ArgumentNullException(nameof(filePath), "The file path can't be null or empty.");
                }

                if(PathValidator.IsValidPath(filePath) == false) return;

                Console.WriteLine(File.ReadAllText(filePath));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while reading file: {ex.Message}");
            }
        }
        public void RenameFile(string oldFileNameWithPath, string newFileNameWithPath)
        {
            try
            {
                if (string.IsNullOrEmpty(oldFileNameWithPath))
                {
                    throw new ArgumentNullException(nameof(oldFileNameWithPath), "The renamed file path can't be null or empty.");
                }

                if (string.IsNullOrEmpty(newFileNameWithPath))
                {
                    throw new ArgumentNullException(nameof(newFileNameWithPath), "The new path for renamed file can't be null or empty.");
                }

                if(PathValidator.IsValidPath(oldFileNameWithPath) == false) return;
                if(PathValidator.IsValidNewPath(newFileNameWithPath) == false) return;

                File.Move(oldFileNameWithPath, newFileNameWithPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while renaming file: {ex.Message}");
            }
        }

    }

}

