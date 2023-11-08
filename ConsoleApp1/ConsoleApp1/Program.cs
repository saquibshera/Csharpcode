
using ConsoleApp1.Models;


EmployeefatwaContext emp = new EmployeefatwaContext();
var data=emp.Tableemployees.ToList();

foreach (var item in data)
{
    Console.WriteLine(item.Name);
}
