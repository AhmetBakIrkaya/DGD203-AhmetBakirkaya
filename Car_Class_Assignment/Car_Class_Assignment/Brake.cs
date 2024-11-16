using System;

public class Brake
{
    public string BrakeType { get; set; }
    public Brake(string brakeType)
    {
        BrakeType = brakeType;
    }

    public void ApplyBrake()
    {
        Console.WriteLine($"{BrakeType} brake was applied.");
    }
}