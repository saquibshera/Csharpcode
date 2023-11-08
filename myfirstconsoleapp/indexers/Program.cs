// See https://aka.ms/new-console-template for more information


class Program
{
    static void Main()
    {
        props  pro = new props();
        pro[0] = "saquib";
        pro[1] = "tyler";
      

        for(int i = 0; i < 2; i++) {
            Console.WriteLine(pro[i]);
        }
    }
}
class props
{
    string[] names = new string[2];
    public string this[int pos]
    {
        get
        {
          return names[pos];
        }
        set
        {
            names[pos] = value;
        }
    }
}
