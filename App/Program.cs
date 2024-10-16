bool ProgramOn = true;
string filePath;
string content;
string sourceFileName;
string destFileName;
string folderPath;

while (ProgramOn)
{
    int optionSelected = Utils.MainMenu();
    int option2 = 0;

    switch (optionSelected)
    {
        case 1:
            option2 = Utils.FileMenu();

            switch (option2)
            {
                case 1:
                    Console.WriteLine("Insert the full Path of the file + filename.extension:");
                    filePath = Console.ReadLine();

                    FileManagementService.CreateFile(filePath);
                    break;

                case 2:
                    Console.WriteLine("Insert the full Path of the file + filename.extension:");
                    filePath = Console.ReadLine();

                    FileManagementService.ReadFile(filePath);
                    break;

                case 3:
                    Console.WriteLine("Insert the full Path of the file + filename.extension:");
                    filePath = Console.ReadLine();
                    Console.WriteLine("Now write the content that you wanna insert into File: ");
                    content = Console.ReadLine();

                    FileManagementService.WriteFile(filePath, content);
                    break;

                case 4:
                    Console.WriteLine("Insert the full Path of the file + filename.extension:");
                    filePath = Console.ReadLine();

                    FileManagementService.DeleteFile(filePath);
                    break;

                case 5:
                    Console.WriteLine("Insert the full Path of the file + filename.extension:");
                    string oldFilePath = Console.ReadLine();
                    Console.WriteLine("Insert the full Path of the file + filename.extension:");
                    string newFilePath = Console.ReadLine();

                    FileManagementService.RenameFile(oldFilePath, newFilePath);
                    break;

                case 6:
                    Console.WriteLine("Insert the full Path of the file + filename.extension:");
                    sourceFileName = Console.ReadLine();
                    Console.WriteLine("Insert the full Path of the file + filename.extension:");
                    destFileName = Console.ReadLine();

                    FileManagementService.CopyFile(sourceFileName, destFileName);
                    break;

                case 7:
                    Console.WriteLine("Insert the full Path of the file + filename.extension:");
                    sourceFileName = Console.ReadLine();
                    Console.WriteLine("Insert the full Path of the file + filename.extension:");
                    destFileName = Console.ReadLine();

                    FileManagementService.MoveFile(sourceFileName, destFileName);

                    break;

                case 0:
                    Console.WriteLine("Returning to main menu!");
                    break;
            }

            break;
        case 2:
            option2 = Utils.FolderMenu();

            switch (option2)
            {
                case 1:
                    Console.WriteLine("Insert the full Path of the file + filename.extension:");
                    folderPath = Console.ReadLine();

                    FileManagementService.CreateFolder(folderPath);
                    break;
                case 2:
                    Console.WriteLine("Insert the full Path of the file + filename.extension:");
                    folderPath = Console.ReadLine();

                    FileManagementService.DeleteFolder(folderPath);
                    break;
                case 3:
                    Console.WriteLine("Insert the full Path of the file + filename.extension:");
                    string oldFolderPath = Console.ReadLine();
                    Console.WriteLine("Insert the full Path of the file + filename.extension:");
                    string newFolderPath = Console.ReadLine();

                    FileManagementService.RenameFolder(oldFolderPath,newFolderPath);
                    break;
                case 4:
                    Console.WriteLine("Insert the full Path of the file + filename.extension:");
                    string sourceFolderPath = Console.ReadLine();
                    Console.WriteLine("Insert the full Path of the file + filename.extension:");
                    string destinationFolderPath = Console.ReadLine();

                    FileManagementService.MoveFolder(sourceFolderPath, destinationFolderPath);
                    break;
                case 0:
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