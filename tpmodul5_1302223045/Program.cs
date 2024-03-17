using System;

public class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }
    public void PrintData()
    {
        Console.WriteLine($"Data yang tersimpan adalah : {data}");
    }
}
    
﻿public class HaloGeneric<T>
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
        DataGeneric<string> dataGeneric = new DataGeneric<string>("Y");
        dataGeneric.PrintData();
        DataGeneric<string> nim = new DataGeneric<string>("1302223045");
        nim.PrintData();
        HaloGeneric<string> haloGeneric = new HaloGeneric<string>();
        string namaUser = "Harits";
        haloGeneric.SapaUser(namaUser);
        Console.ReadLine();
    }
}