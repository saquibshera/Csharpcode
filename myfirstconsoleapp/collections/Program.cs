// See https://aka.ms/new-console-template for more information
using System.Collections;
class employee
{
    public string name { get; set; }
    public int age { get; set; }
}
class Program
{
    public static void Main()
    {
        List<employee> list = new List<employee>();
        employee employee = new employee();
        employee.age = 10;
        employee.name = "Test";
        list.Add(employee);
        list.Add(new employee { name="albert",age=23});
        foreach (employee item in list)
        {
            Console.WriteLine("name :{0} age:{1}",item.name,item.age);
        }
        
        //ArrayList ar= new ArrayList();
        //ar.Add(120);
        //ar.Add("saquib");
        //ar.Add(false);
        //foreach(var item in ar)
        //{
        //    Console.WriteLine(item);
        //}
        //Stack stack = new Stack();
        //stack.Push(230);
        //stack.Push("saquib");
        //stack.Pop();
        //foreach(var item in stack)
        //{
        //    Console.WriteLine(item);
        //}
        //Hashtable ht = new Hashtable();
        //ht.Add("Name", "john");
        //ht.Add("Address", "downtown");
        //foreach(var item in ht.Values)
        //{
        //    Console.WriteLine(item);
        //}
    }
}
