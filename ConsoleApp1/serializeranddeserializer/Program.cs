// See https://aka.ms/new-console-template for more information
using System.Xml.Serialization;

public class person
{
    public string Name { get; set; }

    public string Address { get; set; }
}
class program
{
    public static void Main()
    {
        person pr = new person() { Name = "saquib", Address = "UAE" };
        string filepath = @"C:\Users\saqui\OneDrive\Desktop\Siemens\ConsoleApp1\serializeranddeserializer\myfile.xml";
        //serializethedata(filepath,pr);
        deserializethedata(filepath);

    }

    private static void deserializethedata(string filepath)
    {
        XmlSerializer ser = new XmlSerializer(typeof(person));
        Stream file= new FileStream(filepath,FileMode.OpenOrCreate,FileAccess.ReadWrite);
        person pro=(person)ser.Deserialize(file);
        Console.WriteLine("name :{0} Address :{1}",pro.Name,pro.Address);
    }

    private static void serializethedata(string filepath,person pr)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(person));
        Stream file= new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
        serializer.Serialize(file, pr);
        Console.WriteLine("Xml file created");
    }
}
