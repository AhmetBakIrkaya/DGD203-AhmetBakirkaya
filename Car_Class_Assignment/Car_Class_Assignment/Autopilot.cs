using System;

public class Autopilot
{
    public bool HasAutopilot { get; set; }
    public Autopilot(bool hasAutopilot)
    {
        HasAutopilot = hasAutopilot;
    }

    public void UseAutopilot()
    {
        Console.WriteLine(HasAutopilot ? "Autopilot is active!" : "This vehicle does not have autopilot.");
    }
}