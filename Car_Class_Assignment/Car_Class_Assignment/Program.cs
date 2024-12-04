using System;

namespace CarApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(
                new GasolineEngine(),
                new Nitro(true),
                new Fuel(50),
                new Brake("Disc"),
                new Tire("Summer Tire"),
                new Steering("Hydraulic"),
                new Autopilot(false),
                new Durability(100),
                new MaxSpeed(200)
            );

            Car car2 = new Car(
                new DieselEngine(),
                new Nitro(false),
                new Fuel(60),
                new Brake("Drum"),
                new Tire("Winter Tire"),
                new Steering("Mechanical"),
                new Autopilot(true),
                new Durability(120),
                new MaxSpeed(180)
            );

            Car car3 = new Car(
                new ElectricEngine(),
                new Nitro(false),
                new Fuel(80),
                new Brake("Disc"),
                new Tire("All-Season Tire"),
                new Steering("Electric"),
                new Autopilot(true),
                new Durability(150),
                new MaxSpeed(160)
            );

            Console.WriteLine("Car 1 Information:");
            car1.DisplayCarInfo();

            Console.WriteLine("Car 2 Information:");
            car2.DisplayCarInfo();

            Console.WriteLine("Car 3 Information:");
            car3.DisplayCarInfo();
        }
    }
}

//While doing this homework, I got help from chat gpt, sir.