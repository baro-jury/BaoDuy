using System;
using System.Reflection;

public class Program
{
    private static void Main(string[] args)
    {
        //SumOfNumbersInTextFile();
        Console.WriteLine("-------------------------------");
        CopyLargeFiles();
        Console.WriteLine("-------------------------------");
        //CreateCircleComparer();
        Console.WriteLine("-------------------------------");
        //ResizeGeometry();
        Console.WriteLine("-------------------------------");
        //GeometryColor();
    }

    public static void SumOfNumbersInTextFile()
    {
        string projectDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        Console.WriteLine(projectDirectory);
        Console.WriteLine("Please input file path");
        string path = Console.ReadLine();
        Console.WriteLine("File path: " + path);
        ReadTextFileExample example = new ReadTextFileExample();
        example.ReadTextFile(path);
    }

    public static void CopyLargeFiles()
    {
        Console.WriteLine("Enter source file: ");
        string sourcePath = Console.ReadLine();
        Console.WriteLine("Enter destination file: ");
        string destinationPath = Console.ReadLine();

        FileInfo source = new FileInfo(sourcePath);
        FileInfo des = new FileInfo(destinationPath);
        try
        {
            //CopyFileUsingFileInfo(source, des);
            CopyFileUsingStream(source, des);
            Console.WriteLine("Copy Completed");
        }
        catch (IOException e)
        {
            Console.WriteLine("Cannot Copy");
            Console.Error.WriteLine(e.Message);
        }
    }
    private static void CopyFileUsingFileInfo(FileInfo source, FileInfo des)
    {
        Console.WriteLine("Start Copy using FileInfo");
        source.CopyTo(des.FullName, true);
    }
    private static void CopyFileUsingStream(FileInfo source, FileInfo des)
    {
        Console.WriteLine("Start Copy using Stream");
        StreamReader reader = null;
        StreamWriter writer = null;
        try
        {
            reader = new StreamReader(source.FullName);
            writer = new StreamWriter(des.FullName);
            char[] buffer = new char[1024];
            int length;
            while ((length = reader.Read(buffer)) > 0)
            {
                writer.Write(buffer, 0, length);
            }
        }
        finally
        {
            reader.Close();
            reader.Dispose();
            writer.Close();
            writer.Dispose();
        }
    }
}

class ReadTextFileExample
{
    public void ReadTextFile(string filePath)
    {
        try
        {
            FileInfo file = new FileInfo(filePath);
            if (!file.Exists)
            {
                throw new FileNotFoundException();
            }

            StreamReader reader = new StreamReader(filePath);
            string line = "";
            int sum = 0;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
                sum += int.Parse(line);
            }
            reader.Close();
            Console.WriteLine("Total: " + sum);
        }
        catch (Exception)
        {
            Console.Error.WriteLine("File not found or invalid content");
        }
    }
}