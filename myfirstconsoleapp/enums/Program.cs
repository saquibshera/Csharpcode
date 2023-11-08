// See https://aka.ms/new-console-template for more information
public enum daysofweek
{
    Monday=1000,
    tuesday,
    wednesday,
    thursday,
    friday,
    saturday,
    sunday,
}
class Program
{
    public static void Main()
    {
        int[] values = (int[]) Enum.GetValues(typeof(daysofweek));
        foreach (int value in values)
        {
            Console.WriteLine(value);
        }
    }
}
