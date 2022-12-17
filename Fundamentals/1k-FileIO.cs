using System.IO;

class FileIO
{
    string folderPath = @"D:\Apps\.NET Training 5";
    public void CreateFile()
    {
        string fullFilePath = @$"{folderPath}\abc.txt";
        File.WriteAllText(fullFilePath, "This is first text file");
    }

    public void CreateDirectory()
    {
        string newFolderPath = folderPath + "\\abc";
        Directory.CreateDirectory(newFolderPath);
    }

    public void CreateDirectoriesAndFiles()
    {
        // CW - Create ten folders named Folder 1, Folder 2 and so on, inside some root folder
        {
            string rootFolderPath = folderPath + "\\Folder";

            for (int i = 1; i < 11; i++)
            {
                string childFolderPath = "\\Folder" + i;
                Directory.CreateDirectory(childFolderPath);
            }

        }
    }
    public void CreateFolder()
    {
        for (int j=1; j<=10; j++)
        {
        var folderName = "Folder" + j;
        var folderPath = @$"F:\Folder1\{folderName}";
        Directory.CreateDirectory(folderPath);
        var filePath = folderPath + @"\text.cs";
        File.WriteAllText(filePath, $"// I am in {folderName}");

        }
    }  
} 
