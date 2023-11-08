// See https://aka.ms/new-console-template for more information
class exceptionhandling
{
    public static void Main()
    {
        
        try
        {
            int[] arr = new int[2]{ 23,45};
            Console.WriteLine("Enter the number1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 / num2);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(arr[i]);
            }
        } catch (FormatException ex)
        {
            Console.WriteLine("characters not allowed");
        }
        catch(DivideByZeroException ex) {
            Console.WriteLine("Dont divide by zero");
        }
        catch(IndexOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Thanks for using our calculator");
        }
    }
}
