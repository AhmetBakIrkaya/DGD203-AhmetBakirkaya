using System;
public class Fuel
{
    public float FuelAmount { get; private set; }
    public Fuel(float initialFuel)
    {
        FuelAmount = initialFuel;
    }

    public void ConsumeFuel(float amount)
    {
        if (FuelAmount >= amount)
        {
            FuelAmount -= amount;
            Console.WriteLine($"Fuel consumed. Remaining fuel: {FuelAmount}.");
        }
        else
        {
            Console.WriteLine("Not enough fuel!");
        }
    }
}