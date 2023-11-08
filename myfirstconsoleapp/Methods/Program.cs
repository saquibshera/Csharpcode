// See https://aka.ms/new-console-template for more information
class program
{
    public static void Main()
    {
        int num1 = 34;
        int addition=add(23,45,ref num1);//calling of methods
        Console.WriteLine(num1);
        Console.WriteLine("add method called and result is {0}",addition);
    }
    public static int add(int x,int y,ref int num1) //method specification
    {
        num1 = 45;
        Console.WriteLine(num1);
        return x + y;  //method body
    }
}
