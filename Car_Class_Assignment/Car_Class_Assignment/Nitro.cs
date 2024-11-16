using System;

public class Nitro
{
    public bool HasNitro { get; set; }
    public Nitro(bool hasNitro)
    {
        HasNitro = hasNitro;
    }

    public void UseNitro()
    {
        Console.WriteLine(HasNitro ? "Nitro used!" : "This vehicle does not have nitro.");
    }
}