class program
{
    public static void Main()
    {
        newprogram obj = new newprogram(); //instantiate the class
        obj.pinproperty = 1234;
        Console.WriteLine(obj.pinproperty);
    }
}
class newprogram
{
    private int pin;
    public int pinproperty
    {
        get
        {
            return pin+1234;
        }
        set
        {
            this.pin = value;
        }
    }
}
