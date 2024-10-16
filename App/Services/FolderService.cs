using App.Abstractions;

namespace App.Services
{
    internal class FolderService : IFolderService
    {
        public bool CreateFolder(string path)
        {
            try
            {
                if (string.IsNullOrEmpty(path))
                {
                    throw new ArgumentNullException(nameof(path), "O caminho da pasta não pode ser nulo ou vazio.");
                }

                Directory.CreateDirectory(path);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao criar a pasta: {ex.Message}");
                return false;
            }
        }

        public bool DeleteFolder(string path, bool recursive = false)
        {
            try
            {
                if (string.IsNullOrEmpty(path))
                {
                    throw new ArgumentNullException(nameof(path), "O caminho da pasta não pode ser nulo ou vazio.");
                }

                if (!Directory.Exists(path))
                {
                    throw new DirectoryNotFoundException($"A pasta {path} não foi encontrada.");
                }

                Directory.Delete(path, recursive);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao deletar a pasta: {ex.Message}");
                return false;
            }
        }

        public bool RenameFolder(string oldPath, string newPath)
        {
            try
            {
                if (string.IsNullOrEmpty(oldPath))
                {
                    throw new ArgumentNullException(nameof(oldPath), "O caminho antigo não pode ser nulo ou vazio.");
                }

                if (string.IsNullOrEmpty(newPath))
                {
                    throw new ArgumentNullException(nameof(newPath), "O caminho novo não pode ser nulo ou vazio.");
                }

                if (!Directory.Exists(oldPath))
                {
                    throw new DirectoryNotFoundException($"A pasta {oldPath} não foi encontrada.");
                }

                Directory.Move(oldPath, newPath);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao renomear a pasta: {ex.Message}");
                return false;
            }
        }

        public bool MoveFolder(string sourcePath, string destinationPath)
        {
            return RenameFolder(sourcePath, destinationPath);
        }

        public void CopyFolder(string source, string dest)
        {
            if (!Directory.Exists(dest))
            {
                Directory.CreateDirectory(dest);
            }

            foreach (string file in Directory.GetFiles(source))
            {
                string destFile = Path.Combine(dest, Path.GetFileName(file));
                File.Copy(file, destFile);
            }

            foreach (string directory in Directory.GetDirectories(source))
            {
                string newDirectory = Path.Combine(dest, Path.GetFileName(directory));
                CopyFolder(directory, newDirectory);
            }
        }
    }
}
