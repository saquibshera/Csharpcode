using System.Security.Cryptography.X509Certificates;
abstract class absclass{
    public abstract void fun1();

    public int add(int x,int y)
    {
        return x + y;
    }
}
class inheritance:absclass
{
    public static void Main()
    {
        inheritance inh=new inheritance();
        inh.fun1();
        bases bs = new bases(12,67);
        subderivedchanged sd= new subderivedchanged();
        int add=sd.calculate(23, 45);
        Console.WriteLine("Addition is"+add);


    }

    public override void fun1()
    {
        Console.WriteLine("This is abstract method overrided");
    }
}
class bases{
    public bases(int x,int y)
    {

    }
    public int car;
}
sealed class derived:bases
{
    public derived(int x,int y):base(x,y)
    {

    }
    public int bike;
}
class subderived
{
    public virtual int calculate(int x,int y)
    {
        return x + y;
    }
}
class subderivedchanged : subderived
{
    public override int calculate(int x, int y)
    {
        return x * y;
    }
}
