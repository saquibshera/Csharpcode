// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//string[] names = new string[2];
//names[0] = "saquib";
//names[1] = "Daniel";
//foreach (string name in names)
//{
//    Console.WriteLine(name);
//}

int repeat = 2;
int quantity = 0;
int total = 0;

while(repeat==1)
{
    Console.WriteLine("Enter 1 for pizza ");
    int choice=Convert.ToInt32(Console.ReadLine());
    if(choice==1)
    {
        Console.WriteLine("You choose pizza enter quantity");
        quantity=Convert.ToInt32(Console.ReadLine());
        int totalbill = quantity * 20;
        total += totalbill;
    }
    Console.WriteLine("You want more press 2 or 1 to exit");
    repeat =Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Total cost is"+total);





//int[,] arr= new int[2,2];
//arr[0,0] = 23; 
//arr[0,1] = 29;
//arr[1,0] = 35;
//arr[1,1] = 42;
//for (int i = 0;i < 2;i++)
//{
//    for(int j = 0;j < 2;j++)
//    {
//        Console.WriteLine(arr[i,j]);
//    }
//}


