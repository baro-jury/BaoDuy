using System.Reflection;

public class Program
{
    private static void Main(string[] args)
    {
        SumOfNumbersInTextFile();
        Console.WriteLine("-------------------------------");
        //CreateComparableCircle();
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