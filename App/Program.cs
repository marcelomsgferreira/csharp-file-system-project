
IFileService fileService = new FileService();
IFolderService folderService = new FolderService();

FileInputs fileInputs = new FileInputs(fileService);
FolderInputs folderInputs = new FolderInputs(folderService);

bool ProgramOn = true;

while (ProgramOn)
{
    int optionSelected = Helpers.MainMenu();
    int option2 = 0;

    switch (optionSelected)
    {
        case 1:
            option2 = Helpers.FileMenu();

            switch (option2)
            {
                case 1:
                    fileInputs.AddFileInput();
                    break;

                case 2:
                    fileInputs.ReadFileInput();
                    break;

                case 3:
                    fileInputs.WriteFileInput();
                    break;

                case 4:
                    fileInputs.DeleteFileInput();
                    break;

                case 5:
                    fileInputs.RenameFileInput();
                    break;

                case 6:
                    fileInputs.CopyFileInput();
                    break;

                case 7:
                    fileInputs.MoveFileInput();
                    break;

                case 0:
                    Console.WriteLine("Returning to main menu!");
                    break;
            }

            break;
        
        case 2:
            option2 = Helpers.FolderMenu();

            switch (option2)
            {
                case 1:
                    folderInputs.CreateFolderInput();
                    break;
                case 2:
                    folderInputs.DeleteFolderInput();
                    break;
                case 3:
                    folderInputs.RenameFolderInput();
                    break;
                case 4:
                    folderInputs.MoveFolderInput();
                    break;
                case 0:
                    Console.WriteLine("Returning to main menu!");
                    break;
            }

            break;

        case 0:
            
            Console.WriteLine("Are you sure you want to leave(s/n):");
            string areYouSure = Console.ReadLine();

            if (areYouSure.Equals("s") || areYouSure.Equals("S"))
            {
                Console.WriteLine("Alright, GoodBye!");
                ProgramOn = false;
                break;
            }

            break;

        default:
            Console.WriteLine("Invalid Option");
            break;
    }

}