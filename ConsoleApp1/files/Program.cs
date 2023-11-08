class file
{
    public static void Main()
    {
        string path = @"C:\\Users\\saqui\\OneDrive\\Desktop\\Siemens\\ConsoleApp1\\files\Mynewfolder";
       // createfile(path);
        //Writefile(path);
       // Readfile(path);
        Directory.CreateDirectory(path);
        string[] files=Directory.GetFiles(path);
        foreach (string file in files)
        {
            Console.WriteLine(file);
        }
        
    }

    private static void Readfile(string path)
    {
        if(File.Exists(path))
        {
            string text=File.ReadAllText(path);
            if (text != null)
            {

                Console.WriteLine(text);
            }
            else
            {
                Console.WriteLine("File is empty");
            }
        }
    }

    private static void Writefile(string path)
    {
       string text = "This is file content at date" + DateTime.Now.ToString();
      File.AppendAllText(path, text);
       // string[] lines = new string[] { "saquib", "tyler", "daniel" };
        //File.AppendAllLines(path, lines);
       
    }

    private static void createfile(string path)
    {
        if (!File.Exists(path))
        {
            File.Create(path);
        }
        else
        {
            Console.WriteLine("File already created");
        }
    }
}
