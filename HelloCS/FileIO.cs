using System.IO;
using System;
using System.Runtime.CompilerServices;

public class FileIO
{
    public void LearnFileReading()
    {
        // for absoulte file path  string filePath =@"E:\dot repo\dotnet\README.md";
        string filePath ="Collection.cs";// relative file path 
         if (File.Exists(filePath))
         {
        var fileContent =File.ReadAllText(filePath);
        // @ tesari agadi rakkhexi "" bhitra bhako string lai as it readgarxa ignore escape sequences.
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(fileContent);
         }
    }

    public void LearnFileWriting()
    {
        string filePath="Abc.txt";
        File.WriteAllText(filePath, "This is me writing for the first time in file using c#");
    }

    public void LearnFileInfo()
    {
    string filePath = "Abc.txt";
    FileInfo fileInfo= new FileInfo(filePath);
    var size = fileInfo.Length;
    var createDate = fileInfo.CreationTime;

    Console.WriteLine(filePath);
    Console.WriteLine($"Size :{size} bytes");
    Console.WriteLine($" Created : {createDate}");
    }

    public void LearnDirectory()
    {
       string folderPath = "ICreate";
       Directory.CreateDirectory(folderPath);   

       Console.WriteLine("Do you want to delete") ;
       string confirm = Console.ReadLine();
       if(confirm =="y" || confirm =="yes")
       {
        Directory.Delete(folderPath);
       }

    }
}

    