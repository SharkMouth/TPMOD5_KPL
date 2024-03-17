public class HaloGeneric<T>
{
    public void SapaUser(string namaUser)
    {
        Console.WriteLine($"Halo {namaUser}");
    }
}

class Program
{
static void Main(string[] args)
    {
        HaloGeneric<string> haloGeneric = new HaloGeneric<string>();
        string namaUser = "Harits";
        haloGeneric.SapaUser(namaUser);
        Console.ReadLine();
    }
}