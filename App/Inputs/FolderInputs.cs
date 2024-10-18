namespace App.Inputs
{
    internal class FolderInputs
    {

        private readonly IFolderService _folderService;

        public FolderInputs(IFolderService folderService)
        {
            _folderService = folderService;
        }

        public void CreateFolderInput()
        {
            Console.WriteLine("Insert the full Path of the file + filename.extension:");
            string folderPath = Console.ReadLine();

            _folderService.CreateFolder(folderPath);
        }

        public void DeleteFolderInput()
        {
            Console.WriteLine("Insert the full Path of the file + filename.extension:");
            string folderPath = Console.ReadLine();

            _folderService.DeleteFolder(folderPath);
        }

        public void RenameFolderInput()
        {
            Console.WriteLine("Insert the full Path of the file + filename.extension:");
            string? oldFolderPath = Console.ReadLine();
            Console.WriteLine("Insert the full Path of the file + filename.extension:");
            string? newFolderPath = Console.ReadLine();

            _folderService.RenameFolder(oldFolderPath, newFolderPath);
        }

        public void MoveFolderInput()
        {
            Console.WriteLine("Insert the full Path of the file + filename.extension:");
            string sourceFolderPath = Console.ReadLine();
            Console.WriteLine("Insert the full Path of the file + filename.extension:");
            string destinationFolderPath = Console.ReadLine();

            _folderService.MoveFolder(sourceFolderPath, destinationFolderPath);
        }
    }
}
