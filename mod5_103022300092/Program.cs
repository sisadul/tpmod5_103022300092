// See https://aka.ms/new-console-template for more information


class Program
{
    public static void Main(string[] args)
    {
        HaloGeneric gen = new HaloGeneric();
        String n = Console.ReadLine();
        gen.SapaUser(n);
    }
}
class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine($"Halo {user}");
    }
}
