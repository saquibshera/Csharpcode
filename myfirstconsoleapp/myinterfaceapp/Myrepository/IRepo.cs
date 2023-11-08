using myinterfaceapp.Models;

namespace myinterfaceapp.Myrepository
{
    public interface IRepo
    {
        List<Employee> getdata();
        void sendata();
    }
}
