namespace App.Inputs
{
    internal class FileInputs 
    {
        private readonly IFileService _fileService;

        public FileInputs(IFileService fileService)
        {
            _fileService = fileService;
        }

        public void AddFileInput()
        {
            Console.WriteLine("Insert the full Path of the file + filename.extension:");
            string filePath = Console.ReadLine();

            _fileService.CreateFile(filePath);
        }

        public void ReadFileInput()
        {
            Console.WriteLine("Insert the full Path of the file + filename.extension:");
            string filePath = Console.ReadLine();

            _fileService.ReadFile(filePath);
        }

        public void WriteFileInput()
        {
            Console.WriteLine("Insert the full Path of the file + filename.extension:");
            string filePath = Console.ReadLine();
            Console.WriteLine("Now write the content that you wanna insert into File: ");
            string content = Console.ReadLine();

            _fileService.WriteFile(filePath, content);
        }

        public void DeleteFileInput()
        {
            Console.WriteLine("Insert the full Path of the file + filename.extension:");
            string filePath = Console.ReadLine();

            _fileService.DeleteFile(filePath);

        }

        public void RenameFileInput()
        {
            Console.WriteLine("Insert the full Path of the file you want to rename, with name and extension:");
            string oldFileNameWithPath = Console.ReadLine();
            Console.WriteLine("Insert the full Path of the renamed file, with name and extension:\"");
            string newFileNameWithPath = Console.ReadLine();

            _fileService.RenameFile(oldFileNameWithPath, newFileNameWithPath);
        }

        public void CopyFileInput()
        {
            Console.WriteLine("Insert the full Path of the file you wanna copy, with filename.extension too:");
            string sourceFileName = Console.ReadLine();
            Console.WriteLine("Insert the Path of destination for copy, with the file filename.extension too:");
            string destFileName = Console.ReadLine();

            _fileService.CopyFile(sourceFileName, destFileName);
        }

        public void MoveFileInput()
        {
            Console.WriteLine("Insert the full Path of the file you wanna move (with filename.extension too):");
            string sourceFileName = Console.ReadLine();
            Console.WriteLine("Now insert the full Path for destination forder (with filename.extension too):");
            string destFileName = Console.ReadLine();

            _fileService.MoveFile(sourceFileName, destFileName);

        }
    }

}
