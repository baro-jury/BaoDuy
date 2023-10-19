using Ass11_Sep15;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;

public class Program
{
    private static void Main(string[] args)
    {
        //SumOfNumbersInTextFile();
        Console.WriteLine("-------------------------------");
        //CopyLargeFiles();
        Console.WriteLine("-------------------------------");
        //ReadAndWriteXMLFile();
        Console.WriteLine("-------------------------------");
        //ResizeGeometry();
        Console.WriteLine("-------------------------------");
        //GeometryColor();
    }

    #region Practice
    public static void SumOfNumbersInTextFile()
    {
        //string projectDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        //Console.WriteLine(projectDirectory);
        Console.WriteLine("Please input file path");
        string path = Console.ReadLine();
        Console.WriteLine("File path: " + path);
        FileExample example = new FileExample();
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

    public static void ReadAndWriteXMLFile()
    {
        FileExample example = new FileExample();
        example.ReadXMLFile();
        //example.WriteToXMLFile();
    } 
    #endregion

    public static void Csv()
    {
        string srcPath = "D:\\BaoDuy\\.Unity\\_CodeGym\\BaoDuy\\Ass11_Sep15\\countries.txt";
        string destPath = "D:\\BaoDuy\\.Unity\\_CodeGym\\BaoDuy\\Ass11_Sep15\\countries.csv";
    }
    private static void CoppCsvData(string sourcePath, string destinationPath)
    {
        try
        {
            FileInfo file = new FileInfo(sourcePath);
            if (!file.Exists)
            {
                throw new FileNotFoundException();
            }

            StreamReader reader = new StreamReader(sourcePath);
            string line = "";
            while ((line = reader.ReadLine()) != null)
            {
                string[] arr = line.Split(",");
            }
            reader.Close();
            Console.WriteLine("Total: ");
        }
        catch (Exception)
        {
            Console.Error.WriteLine("File not found or invalid content");
        }
    }
}

class FileExample
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

    public void ReadXMLFile()
    {
        XmlTextReader reader = new XmlTextReader("books.xml");
        while (reader.Read())
        {
            switch (reader.NodeType)
            {
                case XmlNodeType.Element:
                    Console.Write("<" + reader.Name);
                    Console.WriteLine(">");
                    break;
                case XmlNodeType.Text:
                    Console.WriteLine(reader.Value);
                    break;
                case XmlNodeType.EndElement:
                    Console.Write("");
                    break;
            }
        }
    }

    public void WriteToXMLFile()
    {
        Book book = new Book();
        book.Title = "Đắc Nhân Tâm";
        book.Price = 123.5f;

        XDocument xDoc = XDocument.Load("books.xml");
        XElement newBook = new XElement("book",
                new XElement("title", book.Title),
                new XElement("price", book.Price.ToString())
                );

        xDoc.Element("bookstore").Add(newBook);
        xDoc.Save("books.xml");
    }
}