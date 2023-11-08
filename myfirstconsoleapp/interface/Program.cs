// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

interface IManager
{
    void Assigntask();
}
interface Iteamlead
{
    void Assigntask();
    void workontask();
}
interface developer
{
    void workontask();
}

class program
{
    public static void Main()
    {
        bases bs= new bases();
        derived dr= new derived();
        subderived dr2= new subderived();
        

    }
}
class bases{
    public string car; 
}
class derived:bases
{
    public string bike;
}
class subderived:derived
{
    public string bicycle;
}

class Work : IManager, Iteamlead, developer
{
    public void Assigntask()
    {
        throw new NotImplementedException();
    }

    void Iteamlead.Assigntask()
    {
        throw new NotImplementedException();
    }

    void Iteamlead.workontask()
    {
        throw new NotImplementedException();
    }

    void developer.workontask()
    {
        throw new NotImplementedException();
    }
}
