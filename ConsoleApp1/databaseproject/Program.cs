// See https://aka.ms/new-console-template for more information
using databaseproject.Models;

class program
{
    public static void Main()
    {
        EmployeefatwaContext empcon = new EmployeefatwaContext();
        while (true)
        {
            Console.WriteLine("press 1 to enter data and 2 to retrieve 3 to delete");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Enter name address and mobile");
                string name = Console.ReadLine();
                string address = Console.ReadLine();
                string mobile = Console.ReadLine();
                Tableemployee emp = new Tableemployee { Name = name, Address = address, Mobile = mobile };
                empcon.Add(emp);
                empcon.SaveChanges();
                Console.WriteLine("Data submitted successfully");
            }
            else if (choice == 2)
            {

                List<Tableemployee> employees = empcon.Tableemployees.ToList();
                foreach (Tableemployee employee in employees)
                {
                    Console.WriteLine("Name:{0} Address: {1} Mobile {2} ", employee.Name, employee.Address, employee.Mobile);


                }

            }
            else if (choice == 3)
            {
                Console.WriteLine("ENter the id you want to delete");
                int id = Convert.ToInt32(Console.ReadLine());
                var record = (from r in empcon.Tableemployees select r).Where(r => r.Id ==id ).FirstOrDefault();
                if (record != null)
                {
                    empcon.Remove(record);
                    empcon.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Record not found");
                }
            }
            else
            {
                Console.WriteLine("Wrong choice");
            }
        }
    }
}
