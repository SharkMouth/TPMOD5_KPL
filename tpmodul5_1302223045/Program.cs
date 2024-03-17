public class HaloGeneric
{
    public void SapaUser(string namaUser)
    {
        Console.WriteLine($"Halo {namaUser}");
    }

    static void Main(string[] args)
    {
        HaloGeneric haloGeneric = new HaloGeneric();
        string namaUser = "Harits";
        haloGeneric.SapaUser(namaUser);
        Console.ReadLine();
    }
}