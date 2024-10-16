using App.Abstractions;
using System.Text;

namespace App.Services
{
    internal class FileService : IFileService
    {
        // File Management
        public bool CopyFile(string sourcePath, string destinationPath, bool overwrite = false)
        {
            try
            {
                if (string.IsNullOrEmpty(sourcePath))
                {
                    throw new ArgumentNullException(nameof(sourcePath), "O caminho da origem não pode ser nulo ou vazio.");
                }

                if (string.IsNullOrEmpty(destinationPath))
                {
                    throw new ArgumentNullException(nameof(destinationPath), "O caminho do destino não pode ser nulo ou vazio.");
                }

                if (!File.Exists(sourcePath))
                {
                    throw new FileNotFoundException($"O arquivo {sourcePath} não foi encontrado.");
                }

                File.Copy(sourcePath, destinationPath, overwrite);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao copiar o arquivo: {ex.Message}");
                return false;
            }
        }
        public bool DeleteFile(string filePath)
        {
            try
            {
                if (string.IsNullOrEmpty(filePath))
                {
                    throw new ArgumentNullException(nameof(filePath), "O caminho do arquivo não pode ser nulo ou vazio.");
                }

                if (!File.Exists(filePath))
                {
                    throw new FileNotFoundException($"O arquivo {filePath} não foi encontrado.");
                }

                File.Delete(filePath);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao deletar o arquivo: {ex.Message}");
                return false;
            }
        }
        public bool CreateFile(string filePath, bool overwrite = false)
        {
            try
            {
                // Validações
                if (string.IsNullOrEmpty(filePath))
                {
                    throw new ArgumentNullException(nameof(filePath), "O caminho do arquivo não pode ser nulo ou vazio.");
                }

                if (File.Exists(filePath) && !overwrite)
                {
                    throw new IOException($"O arquivo {filePath} já existe. Especifique overwrite = true para sobrescrever.");
                }

                // Cria o arquivo
                File.Create(filePath).Close();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao criar o arquivo: {ex.Message}");
                return false;
            }
        }
        public bool WriteFile(string filePath, string content, bool append = false)
        {
            try
            {
                if (string.IsNullOrEmpty(filePath))
                {
                    throw new ArgumentNullException(nameof(filePath), "O caminho do arquivo não pode ser nulo ou vazio.");
                }

                File.WriteAllText(filePath, content, append ? Encoding.UTF8 : Encoding.Default);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao escrever no arquivo: {ex.Message}");
                return false;
            }
        }
        public bool MoveFile(string sourcePath, string destinationPath)
        {
            try
            {
                if (string.IsNullOrEmpty(sourcePath))
                {
                    throw new ArgumentNullException(nameof(sourcePath), "O caminho da origem não pode ser nulo ou vazio.");
                }

                if (string.IsNullOrEmpty(destinationPath))
                {
                    throw new ArgumentNullException(nameof(destinationPath), "O caminho do destino não pode ser nulo ou vazio.");
                }

                if (!File.Exists(sourcePath))
                {
                    throw new FileNotFoundException($"O arquivo {sourcePath} não foi encontrado.");
                }

                File.Move(sourcePath, destinationPath);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao mover o arquivo: {ex.Message}");
                return false;
            }
        }
        public string? ReadFile(string filePath)
        {
            try
            {
                if (string.IsNullOrEmpty(filePath))
                {
                    throw new ArgumentNullException(nameof(filePath), "O caminho do arquivo não pode ser nulo ou vazio.");
                }

                if (!File.Exists(filePath))
                {
                    throw new FileNotFoundException($"O arquivo {filePath} não foi encontrado.");
                }

                return File.ReadAllText(filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao ler o arquivo: {ex.Message}");
                return null;
            }
        }
        public bool RenameFile(string oldPath, string newPath)
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

                if (!File.Exists(oldPath))
                {
                    throw new FileNotFoundException($"O arquivo {oldPath} não foi encontrado.");
                }

                File.Move(oldPath, newPath);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao renomear o arquivo: {ex.Message}");
                return false;
            }
        }
        
    }

}

