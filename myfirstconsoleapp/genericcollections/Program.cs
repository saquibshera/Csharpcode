// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;

class employee
{
    public int Id { get; set; }

    public string Name { get; set; }
}
class program
{
    public static void Main()
    {
        List<employee> list = new List<employee>();
        list.Add(new employee { Id = 1, Name = "saquib" });
        list.Add(new employee { Id = 2, Name = "Amir" });
        var lists = (from x in list orderby x.Name ascending select x).ToList();
        foreach (employee item in lists)
        {
            Console.WriteLine(item.Name);
        }
        var employee=list.Find(x => x.Id == 1);
        var emp= list.Where(x => x.Name =="saquib").FirstOrDefault();
        if (emp != null)
        {
            list.Remove(employee);
        }
        else
        {
            Console.WriteLine("not found");
        }
        Console.WriteLine("after deleting....");
        foreach (employee item in list)
        {
            Console.WriteLine(item.Name);
        }
    }
}
