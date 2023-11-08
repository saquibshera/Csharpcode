// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;


class program
{
    public static void Main()
    {
        add();
        add(23);
        add(23, 45);
        calculate(n: "john", x:34, y:56);
        int x, y;
        calculatenumbers(23, 45, out x, out y);
        Console.WriteLine("The add is{0} and sub is {1}",x,y);
    }
    public static void calculate(int x, int y,string n)
    {

    }
    public static void calculatenumbers(int num1,int num2,out int add,out int sub)
    {
        add= num1 + num2;
        sub=num1 - num2;
    }
    public static void add()
    {

    }
    public static void add(int x)
    {

    }
    public static void add(int x,int y)
    {

    }
  

}