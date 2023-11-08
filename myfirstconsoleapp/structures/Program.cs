// See https://aka.ms/new-console-template for more information

struct employee
{
  
    public string Name;
    public string Address;
    private void abc()
    {

    }
}
class program
{
    public static void Main()
    {
       
        employee emp1= new employee(); //instantiate the structure
        emp1.Name = "tyler";
        emp1.Address = "US";
        emp1.abc();
        employee emp2= new employee();
        emp2.Name = "indu";
        emp2.Address = "UAE";
        emp2.abc();
    }
}
