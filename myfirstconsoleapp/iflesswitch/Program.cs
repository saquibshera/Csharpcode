// See https://aka.ms/new-console-template for more information
using System;
using myclass;
class Program
{
    public static void Main()
    {
        int res=mycalculation.calculate(23, 45);
        string candidatename = "George";
        //if (candidatename == "Tyler")
        //{
        //    Console.WriteLine("Tyler is there in variable");
        //}
        //else if(candidatename =="indu")
        //{
        //    Console.WriteLine("indu is here");
        //}
        //else if(candidatename =="George")
        //{
        //    Console.WriteLine("George is here");
        //}
        //else
        //{
        //    Console.WriteLine("No option found");
        //}
        switch (candidatename)
        {
            case "Tyler":
                Console.WriteLine("Tyler");
                break;
            case "indu":
                Console.WriteLine("indu");
                break;
            case "George":
                Console.WriteLine("george");
                break;
            default:
                Console.WriteLine("no option");
                break;
        }
    }
   
}
