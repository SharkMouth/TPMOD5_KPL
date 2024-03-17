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

class Program
{
static void Main(string[] args)
    {
        DataGeneric<string> dataGeneric = new DataGeneric<string>("Y");
        dataGeneric.PrintData();
        DataGeneric<string> nim = new DataGeneric<string>("1302223045");
        nim.PrintData();
        Console.ReadLine();
    }
}