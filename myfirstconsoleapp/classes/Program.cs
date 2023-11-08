// See https://aka.ms/new-console-template for more information


class employee
{
    public employee(int x,int y)
    {
        Console.WriteLine("employee constructor called");

    }
    public employee(int x)
    {

    }
    public string name;
    private  void display()
    {
        Console.WriteLine("Welcome");
    }
}
class program
{
    public static void Main()
    {
        employee emp= new employee(23,45);//instantiate constructor gets called
        employee emp2 = new employee(45,56);
        object obj= emp2;  //box it
        employee empold =(employee) obj;  //unbox it
        program.x = 23;
        program.fun1();
        program pr= new program();
        pr.fun2();
    }

    public static int x;

    public static void fun1()
    {

    }
    public void fun2()
    {

    }
}
