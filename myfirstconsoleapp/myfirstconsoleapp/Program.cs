using System;


namespace myclass
{
    class Program
    {
        public static void Main()
        {
            //int x = 12;
            //int y = 13;
            //int z = x + y;
            //int c = x / y;
            //Console.WriteLine("the addition is" + z);
            int rollno;//declare the variable
            rollno = 12; //initialize the variable
            rollno = rollno + 12;
            long newrollno = rollno;
            string number = "200";
            int num1 =Convert.ToInt32(number);
            string number2 = "300";
            int num2= Convert.ToInt32(number2);
            int Result = num1 + num2;
            Console.WriteLine(Result.ToString());
            string x = "hello";
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(x);

            



        }
    }
   public class mycalculation
    {
        public static int calculate(int x,int y)
        {
            return x + y;
        }
    }
}


