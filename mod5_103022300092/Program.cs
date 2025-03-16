// See https://aka.ms/new-console-template for more information

<<<<<<< HEAD

=======
>>>>>>> generic-class
class Program
{
    public static void Main(string[] args)
    {
        HaloGeneric gen = new HaloGeneric();
        String n = Console.ReadLine();
        gen.SapaUser(n);
<<<<<<< HEAD
=======

        DataGeneric<string> dat = new DataGeneric<string>("103022300092");
        dat.PrintData();
>>>>>>> generic-class
    }
}
class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine($"Halo {user}");
    }
}
<<<<<<< HEAD
=======
class DataGeneric<T>
{
    private T data;
    public DataGeneric(T data)
    {
        this.data = data;
    }
    public void PrintData() 
    {
        Console.WriteLine($"Data yang tersimpan adalah: {data}");
    }
}
>>>>>>> generic-class
