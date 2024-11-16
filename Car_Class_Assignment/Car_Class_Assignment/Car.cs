using System;

public class Car
{
    public Engine Engine { get; set; }
    public Nitro Nitro { get; set; }
    public Fuel Fuel { get; set; }
    public Brake Brake { get; set; }
    public Tire Tire { get; set; }
    public Steering Steering { get; set; }
    public Autopilot Autopilot { get; set; }
    public Durability Durability { get; set; }
    public MaxSpeed MaxSpeed { get; set; }
    public Car(Engine engine, Nitro nitro, Fuel fuel, Brake brake, Tire tire, Steering steering, Autopilot autopilot, Durability durability, MaxSpeed maxSpeed)
    {
        Engine = engine;
        Nitro = nitro;
        Fuel = fuel;
        Brake = brake;
        Tire = tire;
        Steering = steering;
        Autopilot = autopilot;
        Durability = durability;
        MaxSpeed = maxSpeed;
    } public void DisplayCarInfo()
    {
        Console.WriteLine($"Engine: {Engine.EngineType}");
        Console.WriteLine($"Nitro: {(Nitro.HasNitro ? "Available" : "Unavailable")}");
        Console.WriteLine($"Fuel: {Fuel.FuelAmount}");
        Console.WriteLine($"Brake Type: {Brake.BrakeType}");
        Console.WriteLine($"Tire Type: {Tire.TireType}");
        Console.WriteLine($"Steering Type: {Steering.SteeringType}");
        Console.WriteLine($"Autopilot: {(Autopilot.HasAutopilot ? "Available" : "Unavailable")}");
        Console.WriteLine($"Durability: {Durability.DurabilityLevel}");
        Console.WriteLine($"Max Speed: {MaxSpeed.Speed} km/h");
        Console.WriteLine();
    }
}