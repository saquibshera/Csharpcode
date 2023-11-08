using myinterfaceapp.Models;

namespace myinterfaceapp.Myrepository
{
    public class Repo : IRepo
    {
        
        public List<Employee> getdata()
        {
          List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() {Id=1,Name="saquib"});
            return employees;
        }

        public void sendata()
        {
            throw new NotImplementedException();
        }
    }
}
